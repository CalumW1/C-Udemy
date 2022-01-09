using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2
{
    class Employee
    {
        // FirstName, Lastname, Salary
        // methods Work() and Pauses();
        // Override the method work, so it indeicates the working hours of the trainee.

        private string FirstName { get; set; }

        private string LastName { get; set; }

        private int Salary { get; set; }

        public Employee(string firstName, string lastName, int salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }

        public void Work()
        {

        }

        public void Pauses()
        {

        }
    }
}
