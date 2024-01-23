using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskManagementServer.Models;

namespace TaskManagementServer.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Assignment> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<TaskCategory> TaskCategories { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure many-to-many relationship between Task and Category
            modelBuilder.Entity<TaskCategory>()
                .HasKey(tc => new { tc.TaskId, tc.CategoryId });

            modelBuilder.Entity<TaskCategory>()
                .HasOne(tc => tc.Task)
                .WithMany(t => t.TaskCategories)
                .HasForeignKey(tc => tc.TaskId);

            modelBuilder.Entity<TaskCategory>()
                .HasOne(tc => tc.Category)
                .WithMany(c => c.TaskCategories)
                .HasForeignKey(tc => tc.CategoryId);
        }
    }
}
