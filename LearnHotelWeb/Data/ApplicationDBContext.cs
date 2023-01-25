using LearnHotelWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnHotelWeb.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Facilities> Facilities { get; set; }
    }
}
