using Microsoft.EntityFrameworkCore;

namespace SpeedyAuth.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}