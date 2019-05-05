using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Parent:User
    {
        public string IdNumber { get; set; }
        public string CellNumber { get; set; }
        public string Email { get; set; }
        public string TelephoneNumber { get; set; }
        public string AccountNumber { get; set; }

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
