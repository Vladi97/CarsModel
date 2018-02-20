using Microsoft.EntityFrameworkCore;

namespace Cars.Models
{
    public class CarContext : DbContext
    {
        public CarContext (DbContextOptions<CarContext> options)
            : base(options)
            {
        }

        public DbSet<Cars.Models.Car> Car { get; set; }
        public DbSet<Cars.Models.Make> Make { get; set; }
    }
}