using App.Entities.Abstract;

namespace App.Entities.Concrete
{
  public class CharacterClass : BaseEntitiy
  {
    public int CharacterId { get; set; }
    public int ClassId { get; set; }

    public Class Class { get; set; }
    public Character Character { get; set; }
  }
}
