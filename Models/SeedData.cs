using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Bookstore2.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookDbContext>();
            //aids in the migration of the model to database
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();

            }
            if (!context.Books.Any())
            {
                //13 objects of seed data to populate the database
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFirst = "Victor",
                        AuthorLast = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95,
                        NumberofPages = 1488

                    },
                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirst = "Doris",
                        AuthorMiddle = "Kearns",
                        AuthorLast = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58,
                        NumberofPages = 944

                    },
                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirst = "Alice",
                        AuthorLast = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611 ",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54,
                        NumberofPages = 832

                    },
                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFirst = "Ronald",
                        AuthorMiddle = "C.",
                        AuthorLast = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61,
                        NumberofPages = 864

                    },
                  new Book
                  {
                      Title = "Unbroken",
                      AuthorFirst = "Laura",
                      AuthorLast = "Hillenbrand",
                      Publisher = "Random House",
                      ISBN = "978-0812974492",
                      Classification = "Non-Fiction",
                      Category = "Historical",
                      Price = 13.33,
                      NumberofPages = 528

                  },
                  new Book
                  {
                      Title = "The Great Train Robbery",
                      AuthorFirst = "Michael",
                      AuthorLast = "Crichton",
                      Publisher = "Vintage",
                      ISBN = "978-0804171281",
                      Classification = "Fiction",
                      Category = "Historical Fiction",
                      Price = 15.95,
                      NumberofPages = 288

                  },
                  new Book
                  {
                      Title = "Deep Work",
                      AuthorFirst = "Cal",
                      AuthorLast = "Newport",
                      Publisher = "Grand Central Publishing",
                      ISBN = "978-1455586691",
                      Classification = "Non-Fiction",
                      Category = "Self-Help",
                      Price = 14.99,
                      NumberofPages = 304

                  },
                  new Book
                  {
                      Title = "It's Your Ship",
                      AuthorFirst = "Michael",
                      AuthorLast = "Abrashoff",
                      Publisher = "Grand Central Publishing",
                      ISBN = "978-1455523023",
                      Classification = "Non-Fiction",
                      Category = "Self-Help",
                      Price = 21.66,
                      NumberofPages = 240

                  },

                  new Book
                  {
                      Title = "The Virgin Way",
                      AuthorFirst = "Richard",
                      AuthorLast = "Branson",
                      Publisher = "Portfolio",
                      ISBN = "978-1591847984",
                      Classification = "Non-Fiction",
                      Category = "Business",
                      Price = 29.16,
                      NumberofPages = 400

                  },
                  new Book
                  {
                      Title = "Sycamore Row",
                      AuthorFirst = "John",
                      AuthorLast = "Grisham",
                      Publisher = "Bantam",
                      ISBN = "978-0553393613",
                      Classification = "Fiction",
                      Category = "Thrillers",
                      Price = 15.03,
                      NumberofPages = 642

                  },

                  new Book
                  {
                      Title = "Catcher in the Rye",
                      AuthorFirst = "J.",
                      AuthorMiddle = "D.",
                      AuthorLast = "Salinger",
                      Publisher = "Little, Brown and Company",
                      ISBN = "978-7543321724",
                      Classification = "Fiction",
                      Category = "Classic",
                      Price = 5.99,
                      NumberofPages = 240

                  },

                  new Book
                  {
                      Title = "The Kite Runner",
                      AuthorFirst = "Khaled",
                      AuthorLast = "Hosseini",
                      Publisher = "Riverhead Books",
                      ISBN = "978-1594631931",
                      Classification = "Fiction",
                      Category = "Historical Fiction",
                      Price = 12.57,
                      NumberofPages = 400

                  },

                  new Book
                  {
                      Title = "Native Son",
                      AuthorFirst = "Richard",
                      AuthorLast = "Wright",
                      Publisher = "Harper Perennial Modern Classics",
                      ISBN = "978-0060837563",
                      Classification = "Fiction",
                      Category = "Crime",
                      Price = 11.99,
                      NumberofPages = 544

                  }


                );

                context.SaveChanges();
            }
        }
    }
}

