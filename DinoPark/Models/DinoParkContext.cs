using Microsoft.EntityFrameworkCore;

namespace DinoPark.Models
{
    public class DinoParkContext : DbContext
    {
        public DinoParkContext(DbContextOptions<DinoParkContext> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }
    }
}