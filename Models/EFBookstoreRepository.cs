using System;
using System.Linq;
using Bookstore2.Models;

namespace Bookstore2.Models
{
    public class EFBookstoreRespository : IBookRepository
    {
        private BookDbContext _context;

        //constructor
        public EFBookstoreRespository(BookDbContext context)
        {
            _context = context;
        }
        //queries through our list of books
        public IQueryable<Book> Books => _context.Books;
    }
}

