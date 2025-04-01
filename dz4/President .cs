using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    public class President : Worker
    {
        public override void Print()
        {
            Console.WriteLine("I am the President, responsible for the overall leadership and direction of the company.");
        }
    }
}
