using System.ComponentModel.DataAnnotations;

namespace BookStoreProject.Models
{
    public class ShoppingCart
    {
        public ProductEntity Product { get; set; }
        [Range(1, 1000, ErrorMessage = "Please enter a value between 1 and 1000")]
        public int Count { get; set; }
    }
}
