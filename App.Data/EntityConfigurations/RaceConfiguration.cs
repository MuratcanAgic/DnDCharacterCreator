using App.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.DataAccess.EntityConfigurations
{
  public class RaceConfiguration : IEntityTypeConfiguration<Race>
  {
    public void Configure(EntityTypeBuilder<Race> builder)
    {
      builder.HasKey(x => x.Id);
      builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

      List<Race> data = new List<Race>()
            {
                new Race{Id = 1, Name="Human"},
                new Race{Id = 2, Name="Elf"},
                new Race{Id = 3, Name="Drow"},
                new Race{Id = 4, Name="Half-Elf"},
                new Race{Id = 5, Name="Half-Orc"},
                new Race{Id = 6, Name="Halfling"},
                new Race{Id = 7, Name="Dwarf"},
                new Race{Id = 8, Name="Gnome"},
                new Race{Id = 9, Name="Tiefling"},
                new Race{Id = 10, Name="Githyanki"},
                new Race{Id = 11, Name="Dragonborn"}
            };

      builder.HasData(data);
    }
  }
}
