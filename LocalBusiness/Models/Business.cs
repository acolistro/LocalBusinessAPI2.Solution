namespace LocalBusiness.Models
{
    public class Business
    {
        public int BusinessId { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }
        public int YearJoined { get; set; }
        public int CertNumber { get; set; }
        public decimal Location { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}