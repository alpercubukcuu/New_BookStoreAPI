using FluentValidation;

namespace WebApi.Application.AuthorOperations.Commands;

public class UpdateAuthorCommandValidator : AbstractValidator<UpdateAuthorCommand>
{
    public UpdateAuthorCommandValidator()
    {
        RuleFor(command => command.Model.Name)
            .NotNull()
            .NotEmpty();
          
        RuleFor(command => command.Model.Surname)
            .NotNull()
            .NotEmpty();

        RuleFor(command => command.Model.Birthdate)
            .NotNull()
            .NotEmpty();
            
    }
}
