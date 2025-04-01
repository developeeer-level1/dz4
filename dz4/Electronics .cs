using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    public class Electronics : Product1
    {
        public Electronics(string name, double price) : base(name, price) { }
        public override double CalculateDiscount()
        {
            return Price * 0.1;
        }
    }
}
