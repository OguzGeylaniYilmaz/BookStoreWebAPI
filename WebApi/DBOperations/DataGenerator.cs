using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using WebApi.Entities;

namespace WebApi.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
            {
                if (context.Books.Any())
                {
                    return;
                }

                context.Genres.AddRange(

                    new Genre
                    {
                        Name = "Personel Growth"
                    },
                    new Genre
                    {
                        Name = "Science Fiction"
                    },
                    new Genre
                    {
                        Name = "Romance"
                    }
                   );

                context.Books.AddRange(
                    new Book
                    {
                        //BookId = 1,
                        Title = "Lean Startup",
                        GenreId = 1,
                        PageCount = 300,
                        PublishDate = new DateTime(2001, 06, 12)
                    },
                    new Book
                    {
                     //BookId = 2,
                     Title = "Herland",
                     GenreId = 2,
                     PageCount = 250,
                     PublishDate = new DateTime(2009, 11, 15)
                    },
                    new Book
                    {
                    //BookId = 3,
                    Title = "Dune",
                    GenreId = 2,
                    PageCount = 450,
                    PublishDate = new DateTime(2001, 12, 21)
                    }
                  );

                context.SaveChanges();
            }
        }
    }
}
