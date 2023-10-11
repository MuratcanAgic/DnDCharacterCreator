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
    }
  }
}
