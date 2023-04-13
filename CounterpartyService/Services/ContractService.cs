using Counterparty_Service.Repositories.Entities;
using Counterparty_Service.Repositories.Interfaces;
using Counterparty_Service.Services.Interfaces;
using Counterparty_Service.Model;


namespace Counterparty_Service.Services
{
    public class ContractService : IContractService
    {
        private readonly IContractRepository _contractRepository;
        public ContractService(IContractRepository contractRepository)
        {
            _contractRepository = contractRepository;
        }
        public async Task<Contract> CreateAsync(int counterpartyId, string name, string type, string number, DateTime startDate, DateTime endDate, bool active)
        {
            var contract = await _contractRepository.CreateAsync(
                counterpartyId,
                name,
                type,
                number,
                startDate,
                endDate,
                active);

            return new Contract
            {
                CounterpartyId = contract.CounterpartyId,
                Name = contract.Name,
                Type = contract.Type,
                Number = contract.Number,
                StartDate = contract.StartDate, 
                EndDate = contract.EndDate,
                Active = contract.Active
            };
        }

        public async Task<IEnumerable<Contract>> GetAllAsync()
        {
            var contracts = await _contractRepository.GetAllAsync();

            return contracts.Select(contract => new Contract
            { 
                CounterpartyId = contract.CounterpartyId,
                Name = contract.Name,
                Type = contract.Type,
                Number = contract.Number,
                StartDate = contract.StartDate,
                EndDate = contract.EndDate,
                Active = contract.Active
            }).ToList();
        }
    }
}
