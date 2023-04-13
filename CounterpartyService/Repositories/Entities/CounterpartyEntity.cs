using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace Counterparty_Service.Repositories.Entities
{
    public class CounterpartyEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        [Column(TypeName = "timestamp(0) without time zone")]
        public DateTime CreatedDate { get; set; }
        
        [Column(TypeName = "timestamp(0) without time zone")]
        public DateTime UpdatedDate { get; set; }
        public string IPNCode { get; set; }
        public string IBAN { get; set; }
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        //public List<ContractEntity> Contracts { get; set; } = new List<ContractEntity>();
    }
}
