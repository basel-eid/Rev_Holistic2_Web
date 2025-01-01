using System.ComponentModel.DataAnnotations;

namespace Rev_Holistic2_Web.Models
{
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int NumberOfItems { get; set; }
        public int? CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}
