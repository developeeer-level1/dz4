using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    public class Microwave : Device
    {
        public Microwave() : base("Microwave", "Device for reheating food.") { }
        public override void Sound()
        {
            Console.WriteLine("Humming and end signal");
        }
    }
}
