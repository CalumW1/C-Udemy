using System;

namespace CollectionsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask user to enter a value;
            Console.WriteLine("Enter a Value: ");
            string userInput = Console.ReadLine();
            Console.WriteLine();


            // ask user to select a datatype of validate against. 
            Console.WriteLine("Select the datatype you would like to validate against");
            Console.WriteLine();
            
            // print a out all the datatypes from the array. 
            string[] dataTypes = { "String", "Integer", "Boolean" };
            
            int counter = 1;
            foreach(string types in dataTypes)
            {
                Console.WriteLine("Press {0} for {1}", counter, types);
                counter++;
            }

            string userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    // test to see if the userinput is a valid String 
                    int StringCounter = 0;
                    // check each character of the string;
                    foreach(char character in userInput.ToCharArray())
                    {
                        // check if the character is a letter
                        if (Char.IsLetter(character))
                        {
                            StringCounter++;
                            // if counter is equal to the length of the word 
                            // return valid message
                            if (StringCounter == userInput.ToCharArray().Length)
                            {
                                Console.WriteLine("is a valid {0} string", userInput);
                            }
                        }
                        // if false, return invalid input. 
                        else
                        {
                            Console.WriteLine("{0} isn't a valid string", userInput);
                            break;
                        }
                    }
                    break;
                case "2":
                    // test to see if the userinput is a valid Integer
                    int ValidInt;
                    bool isValid = int.TryParse(userInput, out ValidInt);
                    // If true return valid method, if false return inValid.
                    if (isValid)
                    {
                        Console.WriteLine("Is {0} a valid Int", ValidInt);
                    }
                    else
                    {
                        Console.WriteLine("Isn't a valid Int");
                    }
                    break;
                case "3":
                    // test to see if the userinput is a valid Boolean
                    if(userInput.ToLower() == "true" || userInput.ToLower() == "false")
                    {
                        Console.WriteLine("{0} is a valid input", userInput);
                    }
                    else
                    {
                        Console.WriteLine("{0} isn't a valid input", userInput);
                    }
                    break;
            }

            Console.ReadLine();
        }
    }
}
