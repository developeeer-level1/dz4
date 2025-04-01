using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    internal class Product
    {
        private string name;
        private float priceInCash;
        private float priceOutCents;
        public Product(string name, float money, float cents)
        {
            this.name = name;
            this.priceInCash = money;
            this.priceOutCents = cents;
        }
        public void DecreasePrice(Money money)
        {
            money.Decrease(priceInCash, priceOutCents);
        }
        public void DisplayInfo()
        {
            Console.Write($"{name}: ");
            Console.WriteLine($"Price: {Math.Round(priceInCash+(priceOutCents/100), 2)}");
        }
    }
}
