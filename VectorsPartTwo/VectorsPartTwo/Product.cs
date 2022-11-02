using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Product
    {
        protected string? Name {get; set; }
        protected double? Price { get; set; }

        public Product() { }

        public Product(string name, double price): this()
        {
            Name = name;
            Price = price;
        }
    }
}
