using Counterparty_Service.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Counterparty_Service
{
    public class ApplicationBbContext : DbContext
    {
        public DbSet<CounterpartyEntity> Counterparty { get; set; }
        public DbSet<ContractEntity> Contracts { get; set; }

        public ApplicationBbContext(DbContextOptions<ApplicationBbContext> dbContextOptions)
            : base(dbContextOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        { 
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<CounterpartyEntity>().HasMany(e => e.Contracts).WithOne(e => e.Counterparty).HasForeignKey(e => e.CounterpartyId).IsRequired();
            //modelBuilder.Entity<ContractEntity>().HasOne(e => e.Counterparty).WithMany(e => e.Contracts).HasForeignKey(e => e.CounterpartyId).IsRequired();
        }
    }
}
