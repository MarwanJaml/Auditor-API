using APi.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace APi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<OfficeInfo> OfficeInfos { get; set; }
        public DbSet<User> Users { get; set; } 
    }
}
