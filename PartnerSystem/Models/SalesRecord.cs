using System;

namespace PartnerSystem.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public int PartnerId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}