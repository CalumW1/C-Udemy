using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class cube : Shape
    {
        public double Length { get; set; }

        public cube(double length)
        {
            name = "Cube";
            Length = length;
        }

        public override double Volume()
        {
            return Math.Pow(Length, 3);
        }

        public override void getInfo()
        {
            base.getInfo();
            Console.WriteLine("The cube has a length of {0}", Length);
        }
    }
}
