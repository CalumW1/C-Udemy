using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictonaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // sample database; 
            Employee[] employees =
            {
                new Employee("CEO", "TestCEO", 45, 200),
                new Employee("Manager", "TestManager", 30, 23),
                new Employee("HR", "TestHR", 32, 21),
                new Employee("Secretary", "TestSecretary", 29, 18),
                new Employee("Intern", "TestIntern", 22, 8),
            };


            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();


            // insert each employee from the array into the dictionary;
            foreach(Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);
            }

            Employee emp1 = employeesDirectory["CEO"];

            Console.WriteLine("Employee Role: {0}, Employee Name: {1}, Employee age {2}, Employee Salary {3}", emp1.Role, emp1.Name, emp1.Age, emp1.Salary);

            string key = "CTO";

            if (employeesDirectory.ContainsKey(key))
            {
                Console.WriteLine("Key exists");
            }
            else
            {
                Console.WriteLine("Key Doesn't Exists");
            }


            Console.WriteLine("");
            Console.WriteLine("Using TryGetValue");
            // find key using tryGetValue();
            if (employeesDirectory.TryGetValue("CTO", out Employee reuslts))
            {
                Console.WriteLine("Employee Found!");

                Console.WriteLine("Employee Name: {0} ", reuslts.Name);
                Console.WriteLine("Employee Role: {0} ", reuslts.Role);
                Console.WriteLine("Employee Age: {0}", reuslts.Age);
                Console.WriteLine("Employee Salary: {0}", reuslts.Salary);
            }
            else
            {
                Console.WriteLine("Unable to Locate Employee!");
            }


            // update element in dictionary'

            string keyUpdate = "HR";

            if (employeesDirectory.ContainsKey(keyUpdate))
            {
                employeesDirectory[keyUpdate] = new Employee("HR", "NewHR", 26, 18);
            }
            else
            {
                Console.WriteLine("There is no employee with that name");
            }

            // remove element from dictionary 

            string keyRemove = "Intern";

            if (employeesDirectory.Remove(keyRemove))
            {
                Console.WriteLine("Employee with Role/Key {0} was removed! ", keyRemove);
            }
            else
            {
                Console.WriteLine("No Employee found with this key {0}", keyRemove);
            }







            // using ElementAt(i); 
            Console.WriteLine("");
            Console.WriteLine("Using ElementAT");
            for(int i = 0; i < employeesDirectory.Count; i++)
            {
                KeyValuePair<string, Employee> keyValuePair1 = employeesDirectory.ElementAt(i);
                Console.WriteLine("Key: {0}", keyValuePair1.Key);

                Employee employeeValue = keyValuePair1.Value;
                Console.WriteLine("Employee Name: {0} ", employeeValue.Name);
                Console.WriteLine("Employee Role: {0} ", employeeValue.Role);
                Console.WriteLine("Employee Age: {0}", employeeValue.Age);
                Console.WriteLine("Employee Salary: {0}", employeeValue.Salary);

            }


        }
    }

    class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }        public float Rate { get; set; }        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        // Employee constructor;

        public Employee(string role, string name, int age, float Rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = Rate;
        }
    }
}
