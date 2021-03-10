
using Microsoft.AspNetCore.Mvc;
using Bookstore2.Models;
namespace Bookstore2.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        //view component for the cart at the top of our webpage
        private Cart cart;
        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}