namespace PartnerSystem.Models
{
    public class Partner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PartnerType Type { get; set; }
        public string Phone { get; set; }
        public int Rating { get; set; }
        public string Address { get; set; }
        public string Director { get; set; }
        public string Email { get; set; }
    }
}