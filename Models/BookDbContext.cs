using System;
using Microsoft.EntityFrameworkCore;

namespace Bookstore2.Models
{
    public class BookDbContext : DbContext
    {
        
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {

        }
        //book objects for the database
        public DbSet<Book> Books { get; set; }
    }
}

