using App.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.DataAccess.EntityConfigurations
{
  public class AbilityConfiguration : IEntityTypeConfiguration<Ability>
  {
    public void Configure(EntityTypeBuilder<Ability> builder)
    {
      builder.HasKey(x => x.Id);

      builder.Property(x => x.Dexterity).IsRequired().HasDefaultValue(1);
      builder.Property(x => x.Constitution).IsRequired().HasDefaultValue(1);
      builder.Property(x => x.Wisdom).IsRequired().HasDefaultValue(1);
      builder.Property(x => x.Strength).IsRequired().HasDefaultValue(1);
      builder.Property(x => x.Charisma).IsRequired().HasDefaultValue(1);
      builder.Property(x => x.Intelligence).IsRequired().HasDefaultValue(1);

    }
  }
}
