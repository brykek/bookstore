using System;
using System.Collections.Generic;

namespace Bookstore2.Models.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public PagingInfo PagingInfo { get; set; }

        public string Category { get; set; }
    }
}
