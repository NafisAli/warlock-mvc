﻿using System.ComponentModel.DataAnnotations;

namespace WarlockMVC.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
