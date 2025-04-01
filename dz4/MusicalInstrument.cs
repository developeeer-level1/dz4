using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    public class MusicalInstrument
    {
        protected string Name;
        protected string Description;
        protected string HistoryInfo;
        public MusicalInstrument(string name, string description, string history)
        {
            Name = name;
            Description = description;
            HistoryInfo = history;
        }
        public virtual void Sound()
        {
            Console.WriteLine("The musical instrument does not produce sound.");
        }
        public void Show()
        {
            Console.WriteLine($"Instrument name: {Name}");
        }
        public void Desc()
        {
            Console.WriteLine($"Description: {Description}");
        }
        public void History()
        {
            Console.WriteLine($"History: {HistoryInfo}");
        }
    }
}
