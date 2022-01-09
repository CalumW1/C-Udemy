using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();

            int number;

            number = dice.Next(1, 4);

            Console.WriteLine("{0}", number);

            switch (number)
            {
                case 1:
                    Console.WriteLine("Yes");
                    break;
                case 2:
                    Console.WriteLine("No");
                    break;
                case 3:
                    Console.WriteLine("Maybe");
                    break;
            }
        }
    }
}
