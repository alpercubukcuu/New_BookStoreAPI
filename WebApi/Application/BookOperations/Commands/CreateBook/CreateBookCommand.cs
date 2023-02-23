using AutoMapper;
using WebApi.DBOperations;
using WebApi.Models.Entities;

namespace WebApi.Application.BookOperations.Commands;

public class CreateBookCommand
{
    public CreateBookModel Model { get; set; }

    private readonly IBookStoreDbContext _dbContext;
    private readonly IMapper _mapper;

    public CreateBookCommand(IBookStoreDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public void Handle()
    {
        var book = _dbContext.Books.SingleOrDefault(x => x.Title == Model.Title);

        if (book is not null)
        {
            throw new InvalidOperationException("Kitap bulunamad�!");
        }

        var genre = _dbContext.Genres.SingleOrDefault(x => x.Id == Model.GenreId);

        if (genre is null)
        {
            throw new InvalidOperationException("Genre bulunamad�!");
        }

        var author = _dbContext.Authors.SingleOrDefault(x => x.Id == Model.AuthorId);

        if (author is null)
        {
            throw new InvalidOperationException("Yazar bulunamad�!");
        }

        book = _mapper.Map<Book>(Model);

        _dbContext.Books.Add(book);
        _dbContext.SaveChanges();
    }
}

public class CreateBookModel
{
    public string? Title { get; set; }
    public int GenreId { get; set; }
    public int AuthorId { get; set; }
    public int PageCount { get; set; }
    public DateTime PublishedDate { get; set; }
}
