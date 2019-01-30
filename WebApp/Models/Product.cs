using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public byte Rack { get; set; }
        public byte Cell { get; set; }
    }
}
