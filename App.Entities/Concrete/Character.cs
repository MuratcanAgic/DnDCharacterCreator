using App.Core.Entities;
using App.Entities.Abstract;

namespace App.Entities.Concrete
{
  public class Character : BaseEntitiy, IEntity
  {
    public string Name { get; set; }
    public int CharacterLevel { get; set; }
    public int RaceId { get; set; }
    public int AbilityId { get; set; }

    public Race Race { get; set; }
    public Ability Ability { get; set; }
    public virtual ICollection<CharacterClass> CharacterClasses { get; set; }
  }
}
