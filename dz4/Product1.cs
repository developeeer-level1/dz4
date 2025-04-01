using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    public abstract class Product1
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product1(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public abstract double CalculateDiscount();
    }
}
