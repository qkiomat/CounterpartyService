using Counterparty_Service.Repositories.Entities;
using Counterparty_Service.Model;

namespace Counterparty_Service.Services.Interfaces
{
    public interface IContractService
    {
        public Task<IEnumerable<Contract>> GetAllAsync();
        public Task<Contract> CreateAsync(int counterpartyId, string name, string type, string number, DateTime startDate, DateTime endDate, bool active);
    }
}
