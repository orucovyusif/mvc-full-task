using Microsoft.EntityFrameworkCore;
using WebApplication6.Models;

namespace WebApplication6.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Chef> Chefs { get; set; }
    }
}
