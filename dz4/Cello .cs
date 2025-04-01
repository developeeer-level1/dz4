using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    public class Cello : MusicalInstrument
    {
        public Cello() : base("Cello", "A large stringed instrument played with a bow.", "The cello emerged in the 16th century and became a key instrument in orchestras and chamber music.") { }
        public override void Sound()
        {
            Console.WriteLine("The cello produces a deep, resonant sound.");
        }
    }
}
