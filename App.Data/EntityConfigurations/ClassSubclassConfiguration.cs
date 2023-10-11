using App.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.DataAccess.EntityConfigurations
{
  public class ClassSubclassConfiguration : IEntityTypeConfiguration<ClassSubclass>
  {
    public void Configure(EntityTypeBuilder<ClassSubclass> builder)
    {
      builder.HasKey(x => x.Id);

      builder
        .HasOne<Class>(c => c.Class)
        .WithMany(cs => cs.ClassSubclasses)
        .HasForeignKey(x => x.ClassId);

      builder
        .HasOne<Subclass>(sc => sc.Subclass)
        .WithMany(cs => cs.ClassSubclasses)
        .HasForeignKey(x => x.SubclassId);

    }
  }
}
