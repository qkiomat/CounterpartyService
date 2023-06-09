﻿using Counterparty_Service.Repositories.Entities;

namespace Counterparty_Service.Model
{
    public class Counterparty
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string IPNCode { get; set; }
        public string IBAN { get; set; }
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        //public List<Contract>? Contracts { get; set; }
    }
}
