using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace users_api.Models
{
    public class DungeonCompanionDBContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DungeonCompanionDBContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<AuthRecord> AuthRecords { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("dungeonCompanionConnectionString"));
            }
        }
    }
}
