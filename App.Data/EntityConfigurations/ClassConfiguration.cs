using App.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.DataAccess.EntityConfigurations
{
  public class ClassConfiguration : IEntityTypeConfiguration<Class>
  {
    public void Configure(EntityTypeBuilder<Class> builder)
    {
      builder.HasKey(x => x.Id);
      builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
      builder.Property(x => x.ClassLevel).IsRequired();
    }
  }
}
