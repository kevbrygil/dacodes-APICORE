using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace dacodes_APICORE.Models
{
    public class ApiDbContext : DbContext
    {
        public DbSet<User> Users{get;set;}
        public DbSet<Role> Roles{get;set;}
        public DbSet<Course> Courses{get;set;}
        
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) {
            ChangeTracker.Tracked += OnEntityTracked;
            ChangeTracker.StateChanged += OnEntityStateChanged;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<Course>().HasIndex(u => u.Name).IsUnique();
            modelBuilder.Entity<Course>().HasIndex(u => u.Code).IsUnique();
            modelBuilder.Entity<Lesson>().Property(f => f.Order).ValueGeneratedOnAdd();
            modelBuilder.Entity<Enrollment>().Property(b => b.Date_of_enrollment).HasDefaultValueSql("GETUTCDATE()");
        }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        void OnEntityTracked(object sender, EntityTrackedEventArgs e)
        {
            if (!e.FromQuery && e.Entry.State == EntityState.Added && e.Entry.Entity is IHasCreation entity)
                entity.Created_at = DateTime.UtcNow;
        }

        void OnEntityStateChanged(object sender, EntityStateChangedEventArgs e)
        {
            if (e.NewState == EntityState.Modified && e.Entry.Entity is IHasLastModified entity)
                entity.Updated_at = DateTime.UtcNow;
        }
        
    }
}