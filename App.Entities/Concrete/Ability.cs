using App.Core.Entities;
using App.Entities.Abstract;
using System.ComponentModel;

namespace App.Entities.Concrete
{

  public class Ability : BaseEntitiy, IEntity
  {
    public int Strength { get; set; }
    [DisplayName("Çeviklik")]
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }

    /*public int CharacterId { get; set; }
    public Character Character { get; set; }*/
  }
}
