using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace dacodes_APICORE.Models
{
    public class ApiDbContext : DbContext
    {
        public DbSet<User> Users{get;set;}
        
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) {
            ChangeTracker.Tracked += OnEntityTracked;
            ChangeTracker.StateChanged += OnEntityStateChanged;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
        }
        public override int SaveChanges()
        {
            //AddTimestamps();
            return base.SaveChanges();
        }
        /*private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));
 
            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).Created_at = DateTime.UtcNow;
                }
 
                ((BaseEntity)entity.Entity).Updated_at = DateTime.UtcNow;
            }
        }*/

        void OnEntityTracked(object sender, EntityTrackedEventArgs e)
        {
            if (!e.FromQuery && e.Entry.State == EntityState.Added && e.Entry.Entity is IHasCreationLastModified entity)
                entity.Created_at = DateTime.UtcNow;
        }

        void OnEntityStateChanged(object sender, EntityStateChangedEventArgs e)
        {
            if (e.NewState == EntityState.Modified && e.Entry.Entity is IHasCreationLastModified entity)
                entity.Updated_at = DateTime.UtcNow;
        }
        
    }
}