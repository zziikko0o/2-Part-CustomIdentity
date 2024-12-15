﻿using System.ComponentModel.DataAnnotations;

namespace CRUDWithWebApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string? ProductName { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Qty { get; set; }
    }
}
