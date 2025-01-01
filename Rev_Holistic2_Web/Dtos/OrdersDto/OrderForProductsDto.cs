using Rev_Holistic2_Web.Dtos.CustomerDtos;
using System.ComponentModel.DataAnnotations;

namespace Rev_Holistic2_Web.Dtos.OrdersDto
{
    public class OrderForProductsDto
    {
        [Required]
        public int Price { get; set; }
        public CustomerOnlyDto CustomerOnly { get; set; }
    }
}
