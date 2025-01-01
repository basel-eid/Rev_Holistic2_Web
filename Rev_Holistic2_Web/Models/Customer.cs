using System.ComponentModel.DataAnnotations;

namespace Rev_Holistic2_Web.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Phone]
        public string Contact {  get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public ShoppingCart? ShoppingCart { get; set; }
        public IList<Order>? Orders { get; set; }
    }
}
