using App.Core.Entities;
using App.Entities.Abstract;

namespace App.Entities.Concrete
{
  public class ClassSubclass : BaseEntitiy, IEntity
  {
    public int ClassId { get; set; }
    public int SubclassId { get; set; }

    public Class Class { get; set; }
    public Subclass Subclass { get; set; }
  }
}
