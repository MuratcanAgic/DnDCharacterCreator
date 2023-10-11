using App.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace App.DataAccess.Context
{
  public class DatabaseContext : DbContext
  {   //DB Sets
    public DbSet<Character> Characters { get; set; }
    public DbSet<Class> Classess { get; set; }
    public DbSet<Race> Races { get; set; }
    public DbSet<Ability> Abilites { get; set; }
    public DbSet<Subclass> Subclasses { get; set; }
    public DbSet<CharacterClass> CharacterClasses { get; set; }
    public DbSet<ClassSubclass> ClassSubclasses { get; set; }

    public DatabaseContext()
    {

    }
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      //apply entitiy configurations
      modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

      //Seed Database
    }
  }
}
