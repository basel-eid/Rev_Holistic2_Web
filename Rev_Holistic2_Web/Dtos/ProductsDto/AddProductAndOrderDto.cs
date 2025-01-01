using System.ComponentModel.DataAnnotations;

namespace Rev_Holistic2_Web.Dtos.ProductsDto
{
    public class AddProductAndOrderDto
    {
        [Required]
        public string? Name { get; set; }
        [MaxLength(100, ErrorMessage = "Max length is 100")]
        public string? Description { get; set; }
        public int StockQuantity { get; set; }
        public int OrderId { get; set; }
    }
}
