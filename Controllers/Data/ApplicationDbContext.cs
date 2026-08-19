using DotNet_Template1.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet_Template1.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(t => t.Id);
                entity.Property(t => t.Name).IsRequired().HasMaxLength(50);
            });

            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.HasKey(t => t.Id);
                entity.Property(t => t.Title).IsRequired().HasMaxLength(50);
                entity.Property(t => t.Description).IsRequired().HasMaxLength(200);
                entity.Property(t => t.CreatedAt).HasDefaultValueSql("NOW()");

                entity.HasOne(t => t.User).WithMany(u => u.Tasks).HasForeignKey(t => t.UserId).OnDelete(DeleteBehavior.Cascade);
            });





            base.OnModelCreating(modelBuilder);
        }
    }
}
