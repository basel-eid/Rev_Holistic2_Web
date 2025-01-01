using System.ComponentModel.DataAnnotations;

namespace Rev_Holistic2_Web.Dtos.CustomerDtos
{
    public class CustomerOnlyDto
    {
        [Required]
        public string Name { get; set; }
        [Phone]
        public string Contact { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
