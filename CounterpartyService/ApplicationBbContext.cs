using CounterpartyService.Repositories.Entities;
using Microsoft.EntityFrameworkCore;

namespace CounterpartyService
{
    public class ApplicationBbContext : DbContext
    {
        public DbSet<CounterpartyEntity> Counterparty { get; set; }
        public DbSet<ContractEntity> Contracts { get; set; }

        public ApplicationBbContext(DbContextOptions<ApplicationBbContext> dbContextOptions)
            : base(dbContextOptions)
        {

        }
    }
}
