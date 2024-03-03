using Botanical.Domain.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Botanical.Persistence
{
    public class BotanicalDbContext(DbContextOptions<BotanicalDbContext> options) : DbContext(options)
    {
        public DbSet<Plant> Plants { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.UtcNow;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.UtcNow;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}