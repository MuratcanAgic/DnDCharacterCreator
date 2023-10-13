using App.Core.Entities;
using App.Entities.Abstract;

namespace App.Entities.Concrete
{
  public class Race : BaseEntitiy, IEntity
  {
    public string Name { get; set; }

    /* public int CharacterId { get; set; }
     public Character Character { get; set; }*/
  }
}
