using FluentValidation;

namespace WebApi.Application.BookOperations.Commands;

public class DeleteBookCommandValidator : AbstractValidator<DeleteBookCommand>
{
    public DeleteBookCommandValidator()
    {
        RuleFor(command => command.BookId)
            .NotNull()
            .GreaterThan(0);
    }
}
