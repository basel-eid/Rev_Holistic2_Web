using Rev_Holistic2_Web.Dtos.OrdersDto;
using Rev_Holistic2_Web.Dtos.ShoppingDtos;
using System.ComponentModel.DataAnnotations;

namespace Rev_Holistic2_Web.Dtos.CustomerDtos
{
    public class CustomerDto
    {
        [Required]
        public string Name { get; set; }
        [Phone]
        public string Contact { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public ShoppingCartOnlyDto ShoppingCartOnlyDto { get; set; }
        public IList<OrderForCustomerDto> orderForCustomerDtos { get; set; }
    }
}
