using System.ComponentModel.DataAnnotations;

namespace BookStoreProject.Models
{
    public class CoverTypeEntity
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Cover Type")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
