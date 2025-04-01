using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    public class Manager : Worker
    {
        public override void Print()
        {
            Console.WriteLine("I am a Manager, overseeing teams and ensuring projects are completed on time.");
        }
    }
}
