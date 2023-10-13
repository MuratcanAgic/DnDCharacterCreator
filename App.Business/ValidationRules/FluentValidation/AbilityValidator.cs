using App.Business.Constants;
using App.Entities.Concrete;
using FluentValidation;

namespace App.Business.ValidationRules.FluentValidation
{
  public class AbilityValidator : AbstractValidator<Ability>
  {
    public AbilityValidator()
    {
      RuleFor(p => p.Intelligence).NotEmpty().GreaterThanOrEqualTo(1).LessThanOrEqualTo(20).WithMessage("{PropertyName}" + Messages.AbilityValueLimit);
      RuleFor(p => p.Strength).NotEmpty().GreaterThanOrEqualTo(1).LessThanOrEqualTo(20).WithMessage("{PropertyName}" + Messages.AbilityValueLimit);
      RuleFor(p => p.Charisma).NotEmpty().GreaterThanOrEqualTo(1).LessThanOrEqualTo(20).WithMessage("{PropertyName}" + Messages.AbilityValueLimit);
      RuleFor(p => p.Wisdom).NotEmpty().GreaterThanOrEqualTo(1).LessThanOrEqualTo(20).WithMessage("{PropertyName}" + Messages.AbilityValueLimit);
      RuleFor(p => p.Dexterity).NotEmpty().GreaterThanOrEqualTo(1).LessThanOrEqualTo(20).WithMessage("{PropertyName}" + Messages.AbilityValueLimit);
      RuleFor(p => p.Constitution).NotEmpty().GreaterThanOrEqualTo(1).LessThanOrEqualTo(20).WithMessage("{PropertyName}" + Messages.AbilityValueLimit);
    }
  }
}
