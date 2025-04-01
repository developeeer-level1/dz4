using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    public class Ukulele : MusicalInstrument
    {
        public Ukulele() : base("Ukulele", "A small stringed instrument from Hawaii.", "The ukulele was introduced to Hawaii in the 19th century by Portuguese immigrants and became popular worldwide.") { }
        public override void Sound()
        {
            Console.WriteLine("The ukulele produces a bright, cheerful sound.");
        }
    }
}
