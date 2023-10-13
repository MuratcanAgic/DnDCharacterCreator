﻿using App.Entities.Concrete;
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

      List<Class> data = new List<Class>()
            {
                new Class{Id = 1, Name="Barbarian"},
                new Class{Id = 2, Name="Bard"},
                new Class{Id = 3, Name="Cleric"},
                new Class{Id = 4, Name="Druid"},
                new Class{Id = 5, Name="Fighter"},
                new Class{Id = 6, Name="Monk"},
                new Class{Id = 7, Name="Paladin"},
                new Class{Id = 8, Name="Ranger"},
                new Class{Id = 9, Name="Rogue"},
                new Class{Id = 10, Name="Sorcerer"},
                new Class{Id = 11, Name="Warlock"},
                new Class{Id = 12, Name="Wizard"}
            };

      builder.HasData(data);
    }
  }
}
