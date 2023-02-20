using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Bob the Rex", Description = "Hard worker but tiny hands. Has weird cravings for other dino buddies.", Type = "Dino", Date = DateTime.Now},
          new Animal { AnimalId = 2, Name = "Bessy the Longneck", Description = "No leaf is safe with bessy on the field. Could be the next NBA star for the dino leagues.", Type = "Dino", Date = DateTime.Now},
          new Animal { AnimalId = 3, Name = "Pierre, with bullhorns", Description = "Like to spend a lot of time underneath shade and strictly planet based. Doesn't like it because of how fierce their horns are.", Type = "Dino", Date = DateTime.Now}
          );
    }
  }
}