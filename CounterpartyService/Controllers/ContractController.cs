using Counterparty_Service.Model;
using Counterparty_Service.Repositories.Interfaces;
using Counterparty_Service.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Counterparty_Service.Controllers
{
    [Route("/contract")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        private readonly IContractService _contractService;
        public ContractController(IContractService contractService)
        {
            _contractService = contractService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var contract = await _contractService.GetAllAsync();
            return Ok(contract);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Contract contract)
        {
            var createdContract = await _contractService.CreateAsync(
                contract.CounterpartyId,
                contract.Name, 
                contract.Type, 
                contract.Number,
                contract.StartDate,
                contract.EndDate, 
                contract.Active);
            return Ok(createdContract);
        }
    }
}
