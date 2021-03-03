using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bookstore2.Models;
using Bookstore2.Models.ViewModels;

namespace Bookstore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //number of records on each page
        public int PageSize = 5;

        private IBookRepository _repository;
        //adds repository of books 
        public HomeController(ILogger<HomeController> logger, IBookRepository respository)
        {
            _logger = logger;
            _repository = respository;
        }

        public IActionResult Index(string category, int page = 1)
        {
            return View(new BookListViewModel
            {
                //this line filters the category and pages
                Books = _repository.Books.Where(b => category == null || b.Category == category).OrderBy(b => b.BookID).Skip((page - 1) * PageSize).Take(PageSize)
                ,
                PagingInfo = new PagingInfo
                {
                    //pagination
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalNumItems = category == null ? _repository.Books.Count() : _repository.Books.Where(x => x.Category == category).Count()
                },
                Category = category
            }) ;
            
        }

        public IActionResult Privacy() 
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
