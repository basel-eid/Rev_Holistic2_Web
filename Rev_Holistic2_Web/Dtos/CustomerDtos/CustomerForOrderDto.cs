using Rev_Holistic2_Web.Dtos.ShoppingDtos;
using System.ComponentModel.DataAnnotations;

namespace Rev_Holistic2_Web.Dtos.CustomerDtos
{
    public class CustomerForOrderDto
    {
        [Required]
        public string Name { get; set; }
        [Phone]
        public string Contact { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public ShoppingCartOnlyDto? ShoppingCartOnly { get; set; }
    }
}
