using Counterparty_Service.Repositories.Entities;
using Counterparty_Service.Repositories.Interfaces;
using System.Reflection.Emit;

namespace Counterparty_Service.Repositories
{
    public class CounterpartyRepository : ICounterpartyRepository
    {
        private readonly ApplicationBbContext _context;
        public CounterpartyRepository(ApplicationBbContext context)
        {
            _context = context;
        }

        public async Task<CounterpartyEntity> CreateAsync(string name, string ipn, string iban, string address, string email, string phoneNumber)
        {
            var counterparty = new CounterpartyEntity
            {
                Name = name,
                Description = name,
                Type = "",
                //CreatedDate = DateTime.Now,
                IPNCode = ipn,
                IBAN = iban,
                Address = address,
                Email = email,
                PhoneNumber = phoneNumber
            };

            _context.Counterparty.Add(counterparty);
            _context.SaveChanges();

            return counterparty;
        }

        public async Task<IEnumerable<CounterpartyEntity>> GetAllAsync()
        {
            return _context.Counterparty.ToList();
        }
    }

}
