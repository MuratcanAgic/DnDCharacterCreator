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

      List<Subclass> data = new List<Subclass>()
            {
                //Barbarian
                new Subclass{Id = 1, Name="Berserker"},
                new Subclass{Id = 2, Name="Wild Magic"},
                new Subclass{Id = 3, Name="Wildheart"},
                //Bard
                new Subclass{Id = 4, Name="College of Lore"},
                new Subclass{Id = 5, Name="College of Swords"},
                new Subclass{Id = 6, Name="College of Valour"},
                //Cleric
                new Subclass{Id = 7, Name="Knowledge Domain"},
                new Subclass{Id = 8, Name="Life Domain"},
                new Subclass{Id = 9, Name="Light Domain"},
                new Subclass{Id = 10, Name="Nature Domain"},
                new Subclass{Id = 11, Name="Tempest Domain"},
                new Subclass{Id = 12, Name="Trickery Domain"},
                new Subclass{Id = 13, Name="Trickery War Domain"},
                //Druid
                new Subclass{Id = 14, Name="Circle of the Land"},
                new Subclass{Id = 15, Name="Circle of the Moon"},
                new Subclass{Id = 16, Name="Circle of the Spores"},
                //Fighter
                new Subclass{Id = 17, Name="Battle Master"},
                new Subclass{Id = 18, Name="Champion"},
                new Subclass{Id = 19, Name="Eldritch Knight"},
                //Monk
                new Subclass{Id = 20, Name="Way of the Open Hand"},
                new Subclass{Id = 21, Name="Way of Shadow"},
                new Subclass{Id = 22, Name="Way of the Four Elements"},
                //Paladin
                new Subclass{Id = 23, Name="Oath of the Ancients"},
                new Subclass{Id = 24, Name="Oath of Devotion"},
                new Subclass{Id = 25, Name="Oath of Vengeance"},
                new Subclass{Id = 26,Name="Oathbreaker"},
                //Ranger
                new Subclass{Id = 27, Name="Hunter"},
                new Subclass{Id = 28, Name="Beast Master"},
                new Subclass{Id = 29, Name="Gloom Stalker"},
                //Rogue
                new Subclass{Id = 30,Name="Arcane Trickster"},
                new Subclass{Id = 31,Name="Thief"},
                new Subclass{Id = 32,Name="Assassin"},
                //Sorcerer
                new Subclass{Id = 33,Name="Draconic Bloodline"},
                new Subclass{Id = 34,Name="Wild Magic"},
                new Subclass{Id = 35,Name="Storm Sorcery"},
                //Warlock
                new Subclass{Id = 36,Name="The Archfey"},
                new Subclass{Id = 37,Name="The Fiend"},
                new Subclass{Id = 38,Name="The Great Old One"},
                //Wizard
                new Subclass{Id = 39,Name="Abjuration School"},
                new Subclass{Id = 40,Name="Conjuration School"},
                new Subclass{Id = 41,Name="Divination School"},
                new Subclass{Id = 42,Name="Enchantment School"},
                new Subclass{Id = 43,Name="Evocation School"},
                new Subclass{Id = 44,Name="Illusion School"},
                new Subclass{Id = 45,Name="Necromancy School"},
                new Subclass{Id = 46,Name="Transmutation School"}

            };

      builder.HasData(data);
    }
  }
}
