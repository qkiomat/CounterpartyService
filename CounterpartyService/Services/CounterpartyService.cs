using Counterparty_Service.Model;
using Counterparty_Service.Repositories.Interfaces;
using Counterparty_Service.Services.Interfaces;

namespace Counterparty_Service.Services
{
    public class CounterpartyService : ICounterpartyService
    {
        private readonly ICounterpartyRepository _counterpartyRepository;
        public CounterpartyService(ICounterpartyRepository counterpartyRepository)
        {
            _counterpartyRepository = counterpartyRepository;
        }

        public async Task<Counterparty> CreateAsync(string name, string ipn, string iban, string address, string email, string phoneNumber)
        {
            var counterparty = await _counterpartyRepository.CreateAsync(
                name,
                ipn, 
                iban,
                address,
                email,
                phoneNumber);

            return new Counterparty
            {
                Name = counterparty.Name,
                IPNCode = counterparty.IPNCode,
                IBAN = counterparty.IBAN,
                Address = counterparty.Address,
                Email = counterparty.Email,
                PhoneNumber = counterparty.PhoneNumber
            };
        }

        public async Task<IEnumerable<Counterparty>> GetAllAsync()
        {
            var counterparties = await _counterpartyRepository.GetAllAsync();

            return counterparties.Select(x => new Counterparty 
            {  
                Name = x.Name,
                Description = x.Description,
                Type = x.Type,
                IPNCode = x.IPNCode, 
                IBAN = x.IBAN, 
                Address = x.Address,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber,
                CreatedDate = x.CreatedDate,
                UpdatedDate = x.UpdatedDate   
            }).ToList();
        }
    }
}
