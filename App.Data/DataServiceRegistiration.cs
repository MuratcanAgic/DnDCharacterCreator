using App.DataAccess.Abstract;
using App.DataAccess.Concrete.EntityFramework;
using App.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace App.DataAccess
{
  public static class DataServiceRegistiration
  {
    public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration configuration)
    {
      services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

      services.AddTransient<IAbilityDal, EfAbilityDal>();
      //services.AddTransient<DbContext, DatabaseContext>();
      return services;
    }
  }
}
