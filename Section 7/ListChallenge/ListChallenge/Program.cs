using System;
using System.Collections.Generic;

namespace ListChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new list from the Solutions function;
            List<int> myList = Solution();

            // Print all the numbers in the list to the console.
            foreach(int number in myList)
            {
                Console.WriteLine("{0}", number);
            }
        }

        public static List<int> Solution()
        {
            
            // return all the even numbers in the list; 
            List<int> myList = new List<int>();
            for(int i = 100; i <= 170; i++)
            {
                // check if number is even or odd
                // if even add to list; else disregard;
                if(i % 2 == 0)
                {
                    myList.Add(i);
                }
            }

            return myList;
        }
    }
}
