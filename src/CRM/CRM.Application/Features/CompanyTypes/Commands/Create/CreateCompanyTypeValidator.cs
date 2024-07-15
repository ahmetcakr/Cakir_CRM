using FluentValidation;

namespace CRM.Application.Features.CompanyTypes.Commands.Create;

public class CreateCompanyTypeValidator : AbstractValidator<CreateCompanyTypeCommand>
{

    public CreateCompanyTypeValidator()
    {
        RuleFor(c => c.TypeName)
            .NotEmpty().WithMessage("{PropertyName} is required.");
    }

}
