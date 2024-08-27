using Microsoft.EntityFrameworkCore;
using SchoolSystem.Core.Entities;
using System.Security.Claims;

namespace SchoolSystem.Infrastructure
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<ClassRoom> Classes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<Teacher>().ToTable("Teachers");
            modelBuilder.Entity<ClassRoom>().ToTable("Classes");
        }
    }
}
