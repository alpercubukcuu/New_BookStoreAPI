using FluentValidation;

namespace WebApi.Application.AuthorOperations.Commands;

public class CreateAuthorCommandValidator : AbstractValidator<CreateAuthorCommand>
{
    public CreateAuthorCommandValidator()
    {
        RuleFor(command => command.Model.Name)
            .NotNull();

        RuleFor(command => command.Model.Surname)
            .NotNull();

        RuleFor(command => command.Model.Birthdate)
            .NotNull();
           
    }
}
