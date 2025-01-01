using System.ComponentModel.DataAnnotations;

namespace Rev_Holistic2_Web.Dtos.ShoppingDtos
{
    public class ShoppingCartOnlyDto
    {
        [Required]
        public int? NumberOfItems { get; set; }
    }
}
