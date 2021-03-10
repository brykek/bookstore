using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore2.Infrastructure;
using Bookstore2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bookstore2.Pages
{
    public class BuyModel : PageModel
    {
        private IBookRepository respository;

        //constructor
        public BuyModel(IBookRepository repo, Cart cartService)
        {
            respository = repo;
            Cart = cartService;
        }

        //properties
        public Cart Cart { get; set;}
        public string ReturnUrl { get; set; }

        //methods
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }
        //add items
        public IActionResult OnPost(long BookID, string returnUrl)
        {
            Book book = respository.Books.FirstOrDefault(b => b.BookID == BookID);

            Cart.AddItem(book, 1);

            return RedirectToPage(new { returnUrl = returnUrl });
        }
        //remove items
        public IActionResult OnPostRemove(long BookID, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl =>
                cl.Book.BookID == BookID).Book);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
