using App.Core.DataAccess.EntityFramework;
using App.DataAccess.Abstract;
using App.DataAccess.Context;
using App.Entities.Concrete;

namespace App.DataAccess.Concrete.EntityFramework
{
  public class EfSubclassDal : EfEntityRepositoryBase<Subclass, DatabaseContext>, ISubclassDal
  {
  }
}
