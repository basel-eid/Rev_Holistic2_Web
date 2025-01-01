using Rev_Holistic2_Web.Models;
using System.ComponentModel.DataAnnotations;

namespace Rev_Holistic2_Web.Dtos.OrdersDto
{
    public class OrderOnlyDto
    {
        [Required]
        public int Price { get; set; }
    }
}
