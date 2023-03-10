using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.DBOperations;
using WebApi.Models;

namespace WebApi.Application.BookOperations.Queries;

public class GetBooksQuery
{
    private readonly IBookStoreDbContext _dbContext;
    private readonly IMapper _mapper;

    public GetBooksQuery(IBookStoreDbContext dbOperations, IMapper mapper)
    {
        _dbContext = dbOperations;
        _mapper = mapper;
    }

    public List<BookViewModel> Handle()
    {
        var bookList = _dbContext.Books.Include(x => x.Genre).Include(x => x.Author).OrderBy(x => x.Id).ToList();

        List<BookViewModel> vm = _mapper.Map<List<BookViewModel>>(bookList);


        return vm;
    }
}

public class BookViewModel
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public int PageCount { get; set; }
    public string? PublishedDate { get; set; }
    public string? Genre { get; set; }
    public string? Author { get; set; }
}
