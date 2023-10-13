using App.Business.Abstract;
using App.Business.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace App.Business
{
  public static class BusinessServiceRegistration
  {
    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
      services.AddScoped<IAbilityService, AbilityManager>();
      /*services.AddScoped<IUserService, UserService>();
      services.AddScoped<IAuthService, JwtAuthService>();*/

      return services;
    }
  }
}
