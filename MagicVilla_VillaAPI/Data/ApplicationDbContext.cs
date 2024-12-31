using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext   : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details= "This is a new text for villa",
                    ImageUrl="abc",
                    Occupancy=50,
                    Rate=200,
                    Sqft=100,
                    Amenity= "",
                    CreatedDate= DateTime.Now,
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Royal Villa 2",
                    Details = "This is a new text for villa",
                    ImageUrl = "abc",
                    Occupancy = 40,
                    Rate = 200,
                    Sqft = 100,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                },
                new Villa()
                {
                    Id = 3,
                    Name = "Royal Villa 3",
                    Details = "This is a new text for villa",
                    ImageUrl = "abc",
                    Occupancy = 30,
                    Rate = 200,
                    Sqft = 100,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                },
                new Villa()
                {
                    Id = 4,
                    Name = "Royal Villa 4",
                    Details = "This is a new text for villa",
                    ImageUrl = "abc",
                    Occupancy = 20,
                    Rate = 200,
                    Sqft = 100,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                },
                new Villa()
                {
                    Id = 5,
                    Name = "Royal Villa 5",
                    Details = "This is a new text for villa",
                    ImageUrl = "abc",
                    Occupancy = 10,
                    Rate = 200,
                    Sqft = 100,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                }
                );
        }
    }
}
