using App.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.DataAccess.EntityConfigurations
{
  public class CharacterConfiguration : IEntityTypeConfiguration<Character>
  {
    public void Configure(EntityTypeBuilder<Character> builder)
    {
      builder.HasKey(x => x.Id);
      builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
      builder.Property(x => x.CharacterLevel).IsRequired();

      builder
        .HasOne<Ability>(a => a.Ability)
        .WithOne(cr => cr.Character)
        .HasForeignKey<Ability>(a => a.CharacterId);

      builder
        .HasOne<Race>(r => r.Race)
        .WithOne(cr => cr.Character)
        .HasForeignKey<Race>(a => a.CharacterId);
    }
  }
}
