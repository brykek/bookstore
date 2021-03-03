using System;
using System.Collections.Generic;

namespace Bookstore2.Models.ViewModels
{
    public class BookListViewModel
    {
        //iterates through the books and the number of pages to output with the category
        public IEnumerable<Book> Books { get; set; }
        public PagingInfo PagingInfo { get; set; }

        public string Category { get; set; }
    }
}
