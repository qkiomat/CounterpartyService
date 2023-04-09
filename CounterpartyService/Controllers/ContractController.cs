using CounterpartyService.Model;
using CounterpartyService.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CounterpartyService.Controllers
{
    [Route("/contract")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        private readonly IContractRepository _contractRepository;
        public ContractController(IContractRepository contractRepository)
        {
            _contractRepository = contractRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var contract = await _contractRepository.GetAllAsync();
            return Ok(contract);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Contract contract)
        {
            var createdContract = await _contractRepository.CreateAsync(
                contract.CounterpartyEntityId, 
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
