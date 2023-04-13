using Counterparty_Service.Repositories.Entities;

namespace Counterparty_Service.Model
{
    public class Contract
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Number { get; set; }
        public bool Active { get; set; }
        //public CounterpartyEntity Counterparty { get; set; }
        public int CounterpartyId { get; set; }
    }
}
