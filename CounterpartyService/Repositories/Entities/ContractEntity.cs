﻿namespace CounterpartyService.Repositories.Entities
{
    public class ContractEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Number { get; set; }
        public bool Active { get; set; }
        public int CounterpartyEntityId { get; set; }
    }
}
