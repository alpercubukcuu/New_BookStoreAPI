using FluentValidation;

namespace WebApi.Application.BookOperations.Queries;

public class GetBookDetailQueryValidator : AbstractValidator<GetBookDetailQuery>
{
    public GetBookDetailQueryValidator()
    {
        RuleFor(command => command.BookId)
            .NotNull();


        RuleFor(command => command.BookId)
            .GreaterThanOrEqualTo(0);
    }
}
