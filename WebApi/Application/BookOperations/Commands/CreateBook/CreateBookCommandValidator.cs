using FluentValidation;

namespace WebApi.Application.BookOperations.Commands;

public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
{
    public CreateBookCommandValidator()
    {
        RuleFor(command => command.Model.GenreId)
            .GreaterThan(0);

        RuleFor(command => command.Model.PageCount)
            .GreaterThan(0);

        RuleFor(command => command.Model.PublishedDate.Date)
            .NotEmpty()
            .LessThan(DateTime.Now.Date);

        RuleFor(command => command.Model.Title)
            .MinimumLength(4);
    }
}
