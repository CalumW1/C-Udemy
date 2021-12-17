using System;
using System.Collections.Generic;
using System.Text;

namespace playAround
{
    class Human
    {
        // member variable
        private string firstName;
        private string lastName;
        private string eyeColour;
        private int age;

        // constructor
        public Human(string firstName, string lastName, string eyeColour, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColour = eyeColour;
            this.age = age;
        }


        // member method;
        public void introduction()
        {
            Console.WriteLine("Hello {0} {1} {2} {3}", firstName, lastName, age, eyeColour);
        }
    }
}
