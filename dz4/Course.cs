using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    public class Course
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public Course(string name, int duration)
        {
            Name = name;
            Duration = duration;
        }
        public override string ToString()
        {
            return $"Course Name: {Name}, Duration: {Duration} hours";
        }
    }
}
