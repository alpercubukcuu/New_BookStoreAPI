using FluentValidation;

namespace WebApi.Application.GenreOperations.Commands;

public class DeleteGenreCommandValidator : AbstractValidator<DeleteGenreCommand>
{
    public DeleteGenreCommandValidator()
    {
        RuleFor(command => command.GenreId)
            .NotNull();

        RuleFor(command => command.GenreId)
            .NotEmpty();

        RuleFor(command => command.GenreId)
            .GreaterThanOrEqualTo(0);
    }
}
