using EntityFramework1.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework1.Data
{
    public class DbContextClass : DbContext
    {
        private readonly IConfiguration _configuration;
        public string Cstring { get; set; }
        public DbContextClass(IConfiguration configuration)
        {
            _configuration = configuration;
            Cstring = _configuration["ConnectionStrings:DefaultConnection"];
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Cstring);
        }
        public DbSet<Students> student {  get; set; }
    }
}
