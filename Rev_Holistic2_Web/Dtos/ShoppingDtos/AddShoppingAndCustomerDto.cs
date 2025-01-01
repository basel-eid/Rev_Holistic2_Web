using System.ComponentModel.DataAnnotations;

namespace Rev_Holistic2_Web.Dtos.ShoppingDtos
{
    public class AddShoppingAndCustomerDto
    {
        [Required]
        public int NumberOfItems { get; set; }
        public int CustomerId { get; set; }
    }
}
