using App.Entities.Abstract;

namespace App.Entities.Concrete
{
  public class ClassSubclass : BaseEntitiy
  {
    public int ClassId { get; set; }
    public int SubclassId { get; set; }

    public Class Class { get; set; }
    public Subclass Subclass { get; set; }
  }
}
