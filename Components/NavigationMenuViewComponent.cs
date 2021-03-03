using System;
using Microsoft.AspNetCore.Mvc;
using Bookstore2.Models;
using System.Linq;

namespace Bookstore2.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBookRepository repository;

        public NavigationMenuViewComponent (IBookRepository r)
        {
            repository = r;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Books.Select(x => x.Category).Distinct().OrderBy(x => x));
        }
    }
}
