using System;
using System.Collections.Generic;
using System.Linq;

namespace Bookstore2.Models
{
    public class Cart
    {
        //build a cart line in the cart
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem (Book book, int qty)
        {
            CartLine line = Lines.Where(p => p.Book.BookID == book.BookID).FirstOrDefault();
            //this checks if the item is in the cart or not. if it is, then just add
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = book,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }
        //removes an item from cart
        public virtual void RemoveLine(Book book) =>
            Lines.RemoveAll(x => x.Book.BookID == book.BookID);

        //clears all items from cart
        public virtual void Clear() => Lines.Clear();

        //compute sum of all items in cart
        public decimal ComputeTotalSum() => (decimal)Lines.Sum(e => e.Book.Price * e.Quantity);


        public class CartLine
        {
            public int CartLineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }
    }
}
