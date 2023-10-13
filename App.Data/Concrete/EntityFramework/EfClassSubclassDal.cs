using App.Core.DataAccess.EntityFramework;
using App.DataAccess.Abstract;
using App.DataAccess.Context;
using App.Entities.Concrete;

namespace App.DataAccess.Concrete.EntityFramework
{
  public class EfClassSubclassDal : EfEntityRepositoryBase<ClassSubclass, DatabaseContext>, IClassSubclassDal
  {
    private DatabaseContext _dbContext;
    public EfClassSubclassDal(DatabaseContext context) : base(context)
    {
      _dbContext = context;
    }
  }
}
