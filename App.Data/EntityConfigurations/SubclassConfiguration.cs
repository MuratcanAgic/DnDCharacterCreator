using App.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.DataAccess.EntityConfigurations
{
  public class SubclassConfiguration : IEntityTypeConfiguration<Subclass>
  {
    public void Configure(EntityTypeBuilder<Subclass> builder)
    {
      builder.HasKey(x => x.Id);
      builder.Property(x => x.Name).HasMaxLength(50);
    }
  }
}
