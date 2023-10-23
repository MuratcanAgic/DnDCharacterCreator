using App.Business.Abstract;
using App.Business.Concrete;
using App.Business.ValidationRules.FluentValidation;
using App.Entities.Concrete;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace App.Business
{
  public static class BusinessServiceRegistration
  {
    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
      //service -> manager
      services.AddScoped<IAbilityService, AbilityManager>();
      //validator
      services.AddScoped<IValidator<Ability>, AbilityValidator>();
      return services;
    }
  }
}
