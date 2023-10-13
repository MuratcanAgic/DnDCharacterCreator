using App.Core.DataAccess.EntityFramework;
using App.DataAccess.Abstract;
using App.DataAccess.Context;
using App.Entities.Concrete;

namespace App.DataAccess.Concrete.EntityFramework
{
  public class EfRaceDal : EfEntityRepositoryBase<Race, DatabaseContext>, IRaceDal
  {
    private DatabaseContext _dbContext;
    public EfRaceDal(DatabaseContext context) : base(context)
    {
      _dbContext = context;
    }
  }
}
