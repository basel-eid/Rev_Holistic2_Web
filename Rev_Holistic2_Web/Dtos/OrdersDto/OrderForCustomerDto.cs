using Rev_Holistic2_Web.Dtos.ProductsDto;
using System.ComponentModel.DataAnnotations;

namespace Rev_Holistic2_Web.Dtos.OrdersDto
{
    public class OrderForCustomerDto
    {
        [Required]
        public int Price { get; set; }
        public IList<ProductsOnlyDto> ProductsOnly { get; set; }
    }
}
