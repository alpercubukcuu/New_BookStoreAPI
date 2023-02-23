using FluentValidation;

namespace WebApi.Application.AuthorOperations.Commands;

public class DeleteAuthorCommandValidator : AbstractValidator<DeleteAuthorCommand>
{
    public DeleteAuthorCommandValidator()
    {
        RuleFor(command => command.AuthorId)
            .NotNull()
            .NotEmpty()
            .GreaterThanOrEqualTo(0);
           
    }
}
