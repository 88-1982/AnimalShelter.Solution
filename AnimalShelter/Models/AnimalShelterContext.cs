using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
          .HasData(
              new Animal { AnimalId = 1, Name = "Orion", Species = "Cat", Family = "SavannahCat", Age = 8, Markings = "Black/Brown/Spotted" },
              new Animal { AnimalId = 2, Name = "Thor", Species = "Dog", Family = "Husky", Age = 7, Markings = "Male" },
              new Animal { AnimalId = 3, Name = "Loki", Species = "Cat", Family = "unknown", Age = 9, Markings = "Black/White/" },
              new Animal { AnimalId = 4, Name = "Odin", Species = "Dog", Family = "Pomeranian", Age = 10, Markings = "Brown" },
              new Animal { AnimalId = 5, Name = "Zeus", Species = "Dog", Family = "Pit-Bull", Age = 7, Markings = "Black" }
          );
    }

    public DbSet<Animal> Animals { get; set; }
  }
}