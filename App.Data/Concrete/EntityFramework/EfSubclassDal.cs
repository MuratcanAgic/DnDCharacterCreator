using App.Core.DataAccess.EntityFramework;
using App.DataAccess.Abstract;
using App.DataAccess.Context;
using App.Entities.Concrete;

namespace App.DataAccess.Concrete.EntityFramework
{
  public class EfSubclassDal : EfEntityRepositoryBase<Subclass, DatabaseContext>, ISubclassDal
  {
    private DatabaseContext _dbContext;
    public EfSubclassDal(DatabaseContext context) : base(context)
    {
      _dbContext = context;
    }
  }
}
