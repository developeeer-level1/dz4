using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    public class Trombone : MusicalInstrument
    {
        public Trombone() : base("Trombone", "A brass wind instrument with a telescoping slide.", "The trombone evolved from the sackbut in the 15th century and was used in orchestras and bands.") { }
        public override void Sound()
        {
            Console.WriteLine("The trombone produces a deep, sliding sound.");
        }
    }
}
