using App.Core.DataAccess.EntityFramework;
using App.DataAccess.Abstract;
using App.DataAccess.Context;
using App.Entities.Concrete;

namespace App.DataAccess.Concrete.EntityFramework
{
  public class EfCharacterDal : EfEntityRepositoryBase<Character, DatabaseContext>, ICharacterDal
  {
    private DatabaseContext _dbContext;
    public EfCharacterDal(DatabaseContext context) : base(context)
    {
      _dbContext = context;
    }
  }
}
