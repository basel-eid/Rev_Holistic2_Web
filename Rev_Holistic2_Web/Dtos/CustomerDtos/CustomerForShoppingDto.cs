using Rev_Holistic2_Web.Dtos.OrdersDto;
using System.ComponentModel.DataAnnotations;

namespace Rev_Holistic2_Web.Dtos.CustomerDtos
{
    public class CustomerForShoppingDto
    {
        [Required]
        public string Name { get; set; }
        [Phone]
        public string Contact { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public IList<OrderOnlyDto> orderOnlyDtos { get; set; }
    }
}
