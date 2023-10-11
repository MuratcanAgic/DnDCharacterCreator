using App.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.DataAccess.EntityConfigurations
{
  public class CharacterClassConfiguration : IEntityTypeConfiguration<CharacterClass>
  {
    public void Configure(EntityTypeBuilder<CharacterClass> builder)
    {
      builder.HasKey(x => x.Id);

      builder
        .HasOne<Character>(cr => cr.Character)
        .WithMany(cc => cc.CharacterClasses)
        .HasForeignKey(x => x.CharacterId);

      builder
        .HasOne<Class>(cr => cr.Class)
        .WithMany(cc => cc.CharacterClasses)
        .HasForeignKey(x => x.ClassId);
    }
  }
}
