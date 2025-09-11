using Microsoft.EntityFrameworkCore;
using Schoolsystem.Domain;


namespace Schoolsystem.Persistence
{
    public class School_systemDbContext:DbContext
    {
        public School_systemDbContext(DbContextOptions <School_systemDbContext> options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
