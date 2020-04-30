using Microsoft.EntityFrameworkCore;
using pitang.ons.treinamento.entities;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace pitang.ons.treinamento.repositories.impl
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<User>(entity => {
            //    entity.HasIndex(e => e.Email).IsUnique();
            //});

            modelBuilder.Entity<Contact>()
                .HasOne(e => e.Owner)
                .WithMany(e => e.Contacts)
                .HasForeignKey(e => e.OwnerId);

            modelBuilder.Entity<Contact>()
                .HasOne(e => e.ContactUser)
                .WithMany()
                .HasForeignKey(e => e.ContactUserId);
            
            //modelBuilder.Entity<User>()
            //    .HasMany(e => e.Contacts)
            //    .WithOne()
            //    .HasForeignKey(e => e.OwnerId);

        }

        public void Audit()
        {
            var entries = ChangeTracker.Entries()
                .Where(entry => entry.Entity is AuditEntity &&
                                (entry.State == EntityState.Added ||
                                entry.State == EntityState.Deleted ||
                                entry.State == EntityState.Modified));

            foreach(var entry in entries)
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        ((AuditEntity)entry.Entity).CreatedDate = DateTime.Now;
                        break;
                    case EntityState.Deleted:
                        ((AuditEntity)entry.Entity).LastUpdateDate = DateTime.Now;
                        ((AuditEntity)entry.Entity).IsDeleted = true;
                        break;
                    case EntityState.Modified:
                        ((AuditEntity)entry.Entity).LastUpdateDate = DateTime.Now;
                        break;
                }
            }
        }

        public override int SaveChanges()
        {
            Audit();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            Audit();
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
