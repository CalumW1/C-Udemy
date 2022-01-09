using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new sphere(4), new cube(3) };

            foreach(Shape shape in shapes)
            {
                shape.getInfo();

                Console.WriteLine("{0} has a volume of {1}", shape.name, shape.Volume());

                cube cube2 = shape as cube;

                if(cube2 == null)
                {
                    Console.WriteLine("This shape is not a cube");
                }

                if(shape is cube)
                {
                    Console.WriteLine("This shape is a cube");
                }

                object cube1 = new cube(2);
                cube cube3 = (cube)cube1;

                Console.WriteLine("{0} has a volume of {1}", cube3.name, cube3.Volume());
            }
        }
    }
}
