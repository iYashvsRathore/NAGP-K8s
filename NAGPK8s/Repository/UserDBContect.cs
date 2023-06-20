using Microsoft.EntityFrameworkCore;
using NAGPK8s.Model;

namespace NAGPK8s.Repository
{
    public class UserDBContect : DbContext
    {
        public UserDBContect(DbContextOptions dbContextOptions) : base (dbContextOptions)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
    }
}
