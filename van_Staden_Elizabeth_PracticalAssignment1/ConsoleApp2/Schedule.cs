using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Schedule
    {
        public Student Student { get; set; }
        public List<ClassRoom> ClassRooms { get; set; }
        public bool Mode { get; set; }
        public string StartOfDay { get; set; }
        public string EndOfDay { get; set; }

            
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
