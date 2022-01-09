 using System;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            // Regex
            /*Regex regex = new Regex(@"\d");

            string text = "12323423";

            MatchCollection match = regex.Matches(text);

            Console.WriteLine("{0}", match.Count);*/


            // date time 

            DateTime dateTime = new DateTime(2000, 1, 9);

            Console.WriteLine("{0}", dateTime);

            // current time and date 
            Console.WriteLine("{0}", DateTime.Today);

            // current time 
            Console.WriteLine("{0}", DateTime.Now);

            // Tomorrow 
            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("{0}", tomorrow);

            // return the day of the week 
            Console.WriteLine("{0}", DateTime.Today.DayOfWeek);


            // format date time: 
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));

             
            // Challenge
            // user input for a date in the following format yyyy-mm-dd

            Console.WriteLine("Please enter a date using the following format yyyy-mm-dd");
            string userInputDate = Console.ReadLine();

            // check if the user input is in the valid format 

            if (DateTime.TryParse(userInputDate, out dateTime))
            {
                DateTime now = DateTime.Now;
                TimeSpan dayspassed = now.Subtract(dateTime);
                Console.WriteLine("days passed since you were born {0}", dayspassed.Days);
            }
            else
            {
                Console.WriteLine("Incorrect format");
            }
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
    }
}
