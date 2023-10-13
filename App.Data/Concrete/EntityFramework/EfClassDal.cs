using App.Core.DataAccess.EntityFramework;
using App.DataAccess.Abstract;
using App.DataAccess.Context;
using App.Entities.Concrete;

namespace App.DataAccess.Concrete.EntityFramework
{
  public class EfClassDal : EfEntityRepositoryBase<Class, DatabaseContext>, IClassDal
  {
    private DatabaseContext _dbContext;
    public EfClassDal(DatabaseContext context) : base(context)
    {
      _dbContext = context;
    }
  }
}
