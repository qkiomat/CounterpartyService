using Counterparty_Service.Repositories.Entities;
using Counterparty_Service.Repositories.Interfaces;
using System.Net;

namespace Counterparty_Service.Repositories
{
    public class ContractRepository : IContractRepository
    {
        private readonly ApplicationBbContext _context;
        public ContractRepository(ApplicationBbContext context)
        {
            _context = context;
        }
        public async Task<ContractEntity> CreateAsync(int counterpartyId, string name, string type, string number, DateTime startDate, DateTime endDate, bool active)
        {
            var contract = new ContractEntity
            {
                CounterpartyId = counterpartyId,
                Name = name,
                Type = "",
                StartDate = startDate,
                EndDate = endDate,
                Number = number,
                Active = active
            };

            _context.Contracts.Add(contract);
            _context.SaveChanges();

            return contract;
        }

        public async Task<IEnumerable<ContractEntity>> GetAllAsync()
        {
            return _context.Contracts.ToList();
        }
    }
}
