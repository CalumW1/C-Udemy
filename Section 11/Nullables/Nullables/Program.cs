using System;

namespace Nullables
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("length is equal to zero please provide an input");
                Console.ReadKey();

                return;
            }

            Console.WriteLine("Hello " + args[0]);
            Console.ReadLine();
        }
    }
}
