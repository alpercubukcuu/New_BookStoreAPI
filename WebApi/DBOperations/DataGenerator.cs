using Microsoft.EntityFrameworkCore;
using WebApi.Models.Entities;

namespace WebApi.DBOperations;

public class DataGenerator
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (
            var context = new BookStoreDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()
            )
        )
        {
            if (context.Books.Any())
            {
                return;
            }
            context.Books.AddRange(
                new Book
                {
                    Title = "Lean Startup",
                    GenreId = 1, //Personal Growth
                    PageCount = 100,
                    PublishedDate = new DateTime(2000, 1, 1),
                    AuthorId = 1
                },
                new Book
                {
                    Title = "Herland",
                    GenreId = 2, //Science Fiction
                    PageCount = 250,
                    PublishedDate = new DateTime(2010, 05, 23),
                    AuthorId = 2
                },
                new Book
                {
                    Title = "Dune",
                    GenreId = 2, //Science Fiction
                    PageCount = 540,
                    PublishedDate = new DateTime(2001, 12, 2),
                    AuthorId = 2
                }
            );

            context.Genres.AddRange(
                new Genre { Name = "Personal Growth", },
                new Genre { Name = "Science Fiction" },
                new Genre { Name = "Novel" }
            );

            context.Authors.AddRange(
                new Author
                {
                    Name = "Alper",
                    Surname = "Çubukçu",
                    Birthdate = new DateTime(1994, 12, 13).Date
                },
                new Author
                {
                    Name = "Alp",
                    Surname = "Çubukçu",
                    Birthdate = new DateTime(1995, 12, 13).Date
                },
                new Author
                {
                    Name = "Ozge",
                    Surname = "Çubukçu",
                    Birthdate = new DateTime(1995, 12, 13).Date
                }
            );

            context.SaveChanges();
        }
    }
}
