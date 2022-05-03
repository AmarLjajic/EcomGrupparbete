
using System.ComponentModel.DataAnnotations;

namespace BookStoreProject.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? StreetAdress { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int? PostalCode { get; set; }
        public int? PhoneNumber { get; set; }
    }
}
