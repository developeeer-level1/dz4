using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    internal class Money
    {
        private double all;
        public Money(float money, float cents)
        {
            all = Math.Round(money +(cents/100),2);
        }
        public void Display()
        {
            Console.WriteLine($"{all}");
        }
        public void Decrease(float moneyDecrease, float centDecrease)
        {
            all-= Math.Round(moneyDecrease + (centDecrease / 100), 2);
        }
    }
}
