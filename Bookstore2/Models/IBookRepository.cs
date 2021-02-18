using System;
using System.Linq;

namespace Bookstore2.Models
{
    //template interface for the book class information
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}

