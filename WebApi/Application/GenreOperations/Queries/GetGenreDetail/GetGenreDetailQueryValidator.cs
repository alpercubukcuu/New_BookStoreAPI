using FluentValidation;
using WebApi.Application.GenreOperations.Queries;

public class GetGenreDetailQueryValidator : AbstractValidator<GetGenreDetailQuery>
{
    public GetGenreDetailQueryValidator()
    {
        RuleFor(command => command.GenreId)
            .NotNull();

        RuleFor(command => command.GenreId)
            .GreaterThanOrEqualTo(0);
    }
}
