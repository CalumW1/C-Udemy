using System;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask user to input a string
            Console.Write("Please enter a string: ");
            string UserInput = Console.ReadLine();

            // ask user for a Character.
            Console.Write("Please enter a character you would like to search for: ");
            string UserCharacter = Console.ReadLine();

            // print the position of the character within the string;
            Console.WriteLine("Character is in location {0}", UserInput.IndexOf(UserCharacter));

            // ask user for first and lastname
            string firstName, lastName;

            Console.Write("Please enter your first name: ");
            firstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            lastName = Console.ReadLine();

            // define a full name string;
            string fullName = firstName + " " + lastName;

            Console.WriteLine(fullName);
        }
    }
}
