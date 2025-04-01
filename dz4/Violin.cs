using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    public class Violin : MusicalInstrument
    {
        public Violin() : base("Violin", "A stringed instrument played with a bow.", "The violin originated in 16th century Italy and became a prominent instrument in classical music.") { }
        public override void Sound()
        {
            Console.WriteLine("The violin produces a melodic sound, often used in orchestras.");
        }
    }
}
