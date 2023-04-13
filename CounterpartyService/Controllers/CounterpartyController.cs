using Counterparty_Service.Model;
using Counterparty_Service.Repositories;
using Counterparty_Service.Repositories.Interfaces;
using Counterparty_Service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Counterparty_Service.Controllers
{
    [Route("/counterparty")]
    [ApiController]
    public class CounterpartyController : ControllerBase
    {
        private readonly ICounterpartyService _counterpartyService;
        public CounterpartyController(ICounterpartyService counterpartyService)
        {
            _counterpartyService = counterpartyService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var counterparty = await _counterpartyService.GetAllAsync();
            return Ok(counterparty);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Counterparty counterparty)
        {
            var createdCounterparty = await _counterpartyService.CreateAsync(
                counterparty.Name, 
                counterparty.IPNCode, 
                counterparty.IBAN, 
                counterparty.Address, 
                counterparty.Email, 
                counterparty.PhoneNumber);
            return Ok(createdCounterparty);
        }
    }
}
