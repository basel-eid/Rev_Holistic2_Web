﻿using System.ComponentModel.DataAnnotations;

namespace Rev_Holistic2_Web.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [MaxLength(100,ErrorMessage ="Max length is 100")]
        public string Description { get; set; }
        public int StockQuantity { get; set; }
        public int? OrderId { get; set; }
        public Order? Order { get; set; }
    }
}
