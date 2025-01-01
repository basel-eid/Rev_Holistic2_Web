using System.ComponentModel.DataAnnotations;

namespace Rev_Holistic2_Web.Dtos.OrdersDto
{
    public class AddOrderAndCustomerDto
    {
        [Required]
        public int Price { get; set; }
        public int CustomerId { get; set; }
    }
}
