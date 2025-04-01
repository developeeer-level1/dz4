using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    public class Steamship : Device
    {
        public Steamship() : base("Steamship", "Water transport with steam power.") { }
        public override void Sound()
        {
            Console.WriteLine("Steamship horn: Toooooooot!");
        }
    }
}
