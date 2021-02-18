using System;
using System.Linq;

namespace Bookstore2.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}

