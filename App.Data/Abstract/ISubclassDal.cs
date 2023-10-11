using App.Core.DataAccess.Abstract;
using App.Entities.Concrete;

namespace App.DataAccess.Abstract
{
  public interface ISubclassDal : IEntityRepository<Subclass>
  {
  }
}
