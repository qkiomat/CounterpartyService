using Counterparty_Service.Model;

namespace Counterparty_Service.Services.Interfaces
{
    public interface ICounterpartyService
    {
        public Task<IEnumerable<Counterparty>> GetAllAsync();
        public Task<Counterparty> CreateAsync(string name, string ipn, string iban, string address, string email, string phoneNumber);
    }
}
