using System;
using System.Collections;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();

            // create a bunch of students 
            Student student1 = new Student(1, "Test1", 54);
            Student student2 = new Student(2, "Test2", 12);
            Student student3 = new Student(3, "Test3", 67);
            Student student4 = new Student(4, "Test4", 90);

            // add students to the hash table; using ID as the key
            table.Add(student1.Id, student1);
            table.Add(student2.Id, student2);
            table.Add(student3.Id, student3);
            table.Add(student4.Id, student4);

            // return individual student;
            Student storedStudent = (Student)table[1];
            Console.WriteLine("Student at position 1 is: {0} ", storedStudent);

            // return all the values within the table;
            Console.WriteLine("First way");
            foreach (DictionaryEntry entry in table)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student Id: {0}, Student Name: {1}, Student GPA {2}", temp.Id, temp.Name, temp.GPA);
            }

            // easier way of returning all values in the hashtable
            Console.WriteLine("Second way");
            foreach (Student value in table.Values)
            {
                Console.WriteLine("Student Id: {0}, Student Name: {1}, Student GPA {2}", value.Id, value.Name, value.GPA);
            }
            
        }
    }


    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
        
    }

}
