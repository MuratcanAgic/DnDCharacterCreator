using App.Core.Entities;
using App.Entities.Abstract;

namespace App.Entities.Concrete
{
  public class Class : BaseEntitiy, IEntity
  {
    public string Name { get; set; }


    public virtual ICollection<CharacterClass> CharacterClasses { get; set; }
    public virtual ICollection<ClassSubclass> ClassSubclasses { get; set; }
  }
}
