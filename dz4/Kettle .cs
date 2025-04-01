using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    public class Kettle : Device
    {
        public Kettle() : base("Kettle", "Device for boiling water.") { }
        public override void Sound()
        {
            Console.WriteLine("Hissing and whistling");
        }
    }
}
