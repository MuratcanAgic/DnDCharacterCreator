using App.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.DataAccess.EntityConfigurations
{
  public class ClassClassSubclassConfiguration : IEntityTypeConfiguration<ClassSubclass>
  {
    public void Configure(EntityTypeBuilder<ClassSubclass> builder)
    {
      builder.HasKey(x => x.Id);

      List<ClassSubclass> data = new List<ClassSubclass>()
            {
                //Barbarian
                new ClassSubclass{Id = 1, ClassId=1,SubclassId=1},
                new ClassSubclass{Id = 2, ClassId=1,SubclassId=2},
                new ClassSubclass{Id = 3, ClassId=1,SubclassId=3},
                //Bard
                new ClassSubclass{Id = 4, ClassId=2,SubclassId=4},
                new ClassSubclass{Id = 5, ClassId=2,SubclassId=5},
                new ClassSubclass{Id = 6, ClassId=2,SubclassId=6},
                //Cleric
                new ClassSubclass{Id = 7, ClassId=3,SubclassId=7},
                new ClassSubclass{Id = 8, ClassId=3,SubclassId=8},
                new ClassSubclass{Id = 9, ClassId=3,SubclassId=9},
                new ClassSubclass{Id = 10, ClassId=3,SubclassId=10},
                new ClassSubclass{Id = 11, ClassId=3,SubclassId=11},
                new ClassSubclass{Id = 12, ClassId=3,SubclassId=12},
                new ClassSubclass{Id = 13, ClassId=3,SubclassId=13},
                //Druid
                new ClassSubclass{Id = 14, ClassId=4,SubclassId=14},
                new ClassSubclass{Id = 15, ClassId=4,SubclassId=15},
                new ClassSubclass{Id = 16, ClassId=4,SubclassId=16},
                //Fighter
                new ClassSubclass{Id = 17, ClassId=5,SubclassId=17},
                new ClassSubclass{Id = 18, ClassId=5,SubclassId=18},
                new ClassSubclass{Id = 19, ClassId=5,SubclassId=19},
                //Monk
                new ClassSubclass{Id = 20, ClassId=6,SubclassId=20},
                new ClassSubclass{Id = 21, ClassId=6,SubclassId=21},
                new ClassSubclass{Id = 22, ClassId=6,SubclassId=22},
                //Paladin
                new ClassSubclass{Id = 23, ClassId=7,SubclassId=23},
                new ClassSubclass{Id = 24, ClassId=7,SubclassId=24},
                new ClassSubclass{Id = 25, ClassId=7,SubclassId=25},
                new ClassSubclass{Id = 26,ClassId=7,SubclassId=26},
                //Ranger
                new ClassSubclass{Id = 27, ClassId=8,SubclassId=27},
                new ClassSubclass{Id = 28, ClassId=8,SubclassId=28},
                new ClassSubclass{Id = 29, ClassId=8,SubclassId=29},
                //Rogue
                new ClassSubclass{Id = 30,ClassId=9,SubclassId=30},
                new ClassSubclass{Id = 31,ClassId=9,SubclassId=31},
                new ClassSubclass{Id = 32,ClassId=9,SubclassId=32},
                //Sorcerer
                new ClassSubclass{Id = 33,ClassId=10,SubclassId=33},
                new ClassSubclass{Id = 34,ClassId=10,SubclassId=34},
                new ClassSubclass{Id = 35,ClassId=10,SubclassId=35},
                //Warlock
                new ClassSubclass{Id = 36,ClassId=11,SubclassId=36},
                new ClassSubclass{Id = 37,ClassId=11,SubclassId=37},
                new ClassSubclass{Id = 38,ClassId=11,SubclassId=38},
                //Wizard
                new ClassSubclass{Id = 39,ClassId=12,SubclassId=39},
                new ClassSubclass{Id = 40,ClassId=12,SubclassId=40},
                new ClassSubclass{Id = 41,ClassId=12,SubclassId=41},
                new ClassSubclass{Id = 42,ClassId=12,SubclassId=42},
                new ClassSubclass{Id = 43,ClassId=12,SubclassId=43},
                new ClassSubclass{Id = 44,ClassId=12,SubclassId=44},
                new ClassSubclass{Id = 45,ClassId=12,SubclassId=45},
                new ClassSubclass{Id = 46,ClassId=12,SubclassId=46}

            };

      builder.HasData(data);

    }
  }
}
