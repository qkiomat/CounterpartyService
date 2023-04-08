using CounterpartyService.Model;
using CounterpartyService.Repositories;
using CounterpartyService.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CounterpartyService.Controllers
{
    [Route("/counterparty")]
    [ApiController]
    public class CounterpartyController : ControllerBase
    {
        private readonly ICounterpartyRepository _counterpartyRepository;
        public CounterpartyController(ICounterpartyRepository counterpartyRepository)
        {
            _counterpartyRepository = counterpartyRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var counterparty = await _counterpartyRepository.GetAllAsync();
            return Ok(counterparty);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Counterparty counterparty)
        {
            var createdCounterparty = await _counterpartyRepository.CreateAsync(counterparty.Name, counterparty.IPNCode, counterparty.IBAN, counterparty.Address, counterparty.Email, counterparty.PhoneNumber);
            return Ok(createdCounterparty);
        }
    }
}
