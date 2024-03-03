using Botanical.Application.Contracts.Persistence;
using FluentValidation;

namespace Botanical.Application.Features.Plants.Commands.CreatePlant
{
    public class CreatePlantCommandValidator : AbstractValidator<CreatePlantCommand>
    {

        public CreatePlantCommandValidator()
        {

            RuleFor(r => r.CommonName)
                .NotEmpty()
                .WithSeverity(Severity.Info)
                .WithErrorCode("MustHaveName")
                .WithMessage("Plant must have a name");

            RuleFor(r => r.Type)
                .NotEmpty()
                .WithSeverity(Severity.Info)
                .WithErrorCode("TypeIsRequired")
                .WithMessage("Plant must have a type");
            
        }

    }
}
