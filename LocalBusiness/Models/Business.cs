using System.ComponentModel.DataAnnotations;

namespace LocalBusiness.Models
{
    public class Business
    {
        public int BusinessId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Manager { get; set; }
        [Required]
        public int YearJoined { get; set; }
        [Required]
        public int CertNumber { get; set; }
        [Required]
        public decimal Location { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
    }
}