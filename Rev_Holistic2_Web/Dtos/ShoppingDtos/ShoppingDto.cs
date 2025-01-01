using Rev_Holistic2_Web.Dtos.CustomerDtos;
using System.ComponentModel.DataAnnotations;

namespace Rev_Holistic2_Web.Dtos.ShoppingDtos
{
    public class ShoppingDto
    {
        [Required]
        public int NumberOfItems { get; set; }
        public CustomerOnlyDto CustomerOnly { get; set; }
    }
}
