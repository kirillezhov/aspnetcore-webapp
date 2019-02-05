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
        [Display(Name = "Type")]
        public string Type { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Model")]
        public string Model { get; set; }
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Rack")]
        [Range(1, byte.MaxValue)]
        public byte Rack { get; set; }
        [Display(Name = "Cell")]
        [Range(1, byte.MaxValue)]
        public byte Cell { get; set; }
    }
}
