using Rev_Holistic2_Web.Dtos.CustomerDtos;
using Rev_Holistic2_Web.Dtos.ProductsDto;
using System.ComponentModel.DataAnnotations;

namespace Rev_Holistic2_Web.Dtos.OrdersDto
{
    public class OrderDto
    {
        [Required]
        public int Price { get; set; }
        public IList<ProductsOnlyDto>? productsOnlyDtos { get; set; }
        public CustomerForOrderDto? CustomerOnlyDto { get; set; }
    }
}
