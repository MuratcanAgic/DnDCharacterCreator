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

      //services.AddTransient<ICategoryRepository, CategoryRepository>();


      return services;
    }
  }
}
