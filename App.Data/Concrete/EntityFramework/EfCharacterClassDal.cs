using App.Core.DataAccess.EntityFramework;
using App.DataAccess.Abstract;
using App.DataAccess.Context;
using App.Entities.Concrete;

namespace App.DataAccess.Concrete.EntityFramework
{
  public class EfCharacterClassDal : EfEntityRepositoryBase<CharacterClass, DatabaseContext>, ICharacterClassDal
  {
    private DatabaseContext _dbContext;
    public EfCharacterClassDal(DatabaseContext context) : base(context)
    {
      _dbContext = context;
    }
  }
}
