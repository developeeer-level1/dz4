using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    public class Device
    {
        protected string Name;
        protected string Description;

        public Device(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public virtual void Sound()
        {
            Console.WriteLine("The device does not see sound");
        }

        public void Show()
        {
            Console.WriteLine($"Device name: {Name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Description: {Description}");
        }
    }
}
