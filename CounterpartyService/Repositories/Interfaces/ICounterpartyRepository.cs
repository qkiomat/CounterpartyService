using CounterpartyService.Repositories.Entities;

namespace CounterpartyService.Repositories.Interfaces
{
    public interface ICounterpartyRepository
    {
        public Task<IEnumerable<CounterpartyEntity>> GetAllAsync();

        public Task<CounterpartyEntity> CreateAsync(string name, string ipn, string iban, string address, string email, string phoneNumber);
    }
}
