using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApplication3.Models;

namespace WebApplication3
{
    public class RepositoryContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public RepositoryContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to mysql with connection string from app settings
            var connectionString = Configuration.GetConnectionString("WebApiDatabase");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
        
        

        public DbSet<Country> Countries { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
    }
}