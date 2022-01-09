using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class sphere : Shape
    {

        // raduis of sphere 
        public double Radius { get; set; }

        // constructor 
        public sphere(double radius)
        {
            name = "Sphere";
            Radius = radius;  
        }


        public override double Volume()
        {
            // 3/4 * PI * Radius Cubed.
            return Math.PI * (Math.Pow(Radius, 3)) * 4 / 3;
        }

        public override void getInfo()
        {
            base.getInfo();
            Console.WriteLine("The sphere has a radius of {0}", Radius);
        }


    }
}
