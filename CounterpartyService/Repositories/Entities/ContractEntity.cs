using System.ComponentModel.DataAnnotations.Schema;

namespace Counterparty_Service.Repositories.Entities
{
    public class ContractEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        [Column(TypeName = "timestamp(0) with time zone")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "timestamp(0) with time zone")]
        public DateTime EndDate { get; set; }
        public string Number { get; set; }
        public bool Active { get; set; }
        //public CounterpartyEntity Counterparty { get; set; } = null!;
        public int CounterpartyId { get; set; }
    }
}
