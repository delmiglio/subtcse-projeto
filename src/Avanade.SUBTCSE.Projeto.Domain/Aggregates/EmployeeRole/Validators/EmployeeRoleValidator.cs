using FluentValidation;

namespace Avanade.SUBTCSE.Projeto.Domain.Aggregates.EmployeeRole.Validators
{
    public class EmployeeRoleValidator : AbstractValidator<Entities.EmployeeRole>
    {
        public EmployeeRoleValidator()
        {
            RuleSet("new", () =>
            {
                RuleFor(x => x.RoleName)
                .NotNull()
                .WithMessage(x => $"{x.RoleName} cannot be empty");
            });
        }
    }
}
