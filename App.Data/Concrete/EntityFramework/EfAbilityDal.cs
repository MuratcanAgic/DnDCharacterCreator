using App.Core.DataAccess.EntityFramework;
using App.DataAccess.Abstract;
using App.DataAccess.Context;
using App.Entities.Concrete;

namespace App.DataAccess.Concrete.EntityFramework
{
  public class EfAbilityDal : EfEntityRepositoryBase<Ability, DatabaseContext>, IAbilityDal
  {
    private DatabaseContext _dbContext;
    public EfAbilityDal(DatabaseContext context) : base(context)
    {
      _dbContext = context;
    }
  }
}
