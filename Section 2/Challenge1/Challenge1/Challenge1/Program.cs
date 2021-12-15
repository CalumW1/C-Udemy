using System;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            // define a string
            string name;

            // ask user to their name and assign it a string
            Console.Write("Please enter your name and hit enter: ");
            name = Console.ReadLine();

            // print the string in both upper and lower case. 
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());

            // print string without any white space.
            Console.WriteLine(name.Trim());

            // print a sub string
            Console.WriteLine(name.Substring(0, 3));
        }
    }
}
