using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    abstract class Shape
    {
        public string name { get; set; }
        
        public virtual void getInfo()
        {
            Console.WriteLine("\n this is a {0}", name);
        }

        public abstract double Volume();
    }
}
