using CounterpartyService.Repositories.Entities;

namespace CounterpartyService.Repositories.Interfaces
{
    public interface IContractRepository
    {
        public Task<IEnumerable<ContractEntity>> GetAllAsync();

        public Task<ContractEntity> CreateAsync(int counterpartyId, string name, string type, string number, DateTime startDate, DateTime endDate, bool active);
    }
}
