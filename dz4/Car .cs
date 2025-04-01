using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    public class Car : Device
    {
        public Car() : base("Car", "Transport vehicle for carrying people and goods.") { }
        public override void Sound()
        {
            Console.WriteLine("Engine sound: Vroom-vroom!");
        }
    }
}
