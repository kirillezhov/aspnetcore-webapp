using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Product
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Type { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Model { get; set; }
        public decimal Price { get; set; }

        [Range(1, byte.MaxValue)]
        public byte Rack { get; set; }
        [Range(1, byte.MaxValue)]
        public byte Cell { get; set; }
    }
}
