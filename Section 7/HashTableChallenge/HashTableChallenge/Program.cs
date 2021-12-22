using System;
using System.Collections;

namespace HashTableChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // create hashtable; 
            Hashtable studentTable = new Hashtable();

            // Create a Student array, insert 5 students and 1 student with a duplicate id;
            Students[] students = new Students[5];
            students[0] = new Students(1, "test1", 34);
            students[1] = new Students(2, "test2", 43);
            students[2] = new Students(3, "test3", 76);
            students[3] = new Students(4, "test4", 56);
            students[4] = new Students(1, "Duplicatetest1", 34);

            // loop through the array and insert each student into a HashTable; 
            // if the student id already exists in the table; return error message. 
            // "Sorry a student with that id already exists"

            for(int i = 0; i < students.Length; i++)
            {
                // check to see if the student id already exists;
                if (studentTable.ContainsKey(students[i].Id))
                {
                    Console.WriteLine("Sorry a student with that id already exists");
                }else
                {
                    studentTable.Add(students[i].Id, students[i]);
                }
            }

            // print out each student in the hash table;

            foreach (Students value in studentTable.Values)
            {
                Console.WriteLine("Student ID: {0}, Student Name: {1}, Student GPA: {2}", value.Id, value.Name, value.GPA);
            }
        }
    }

    class Students 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Students(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }

}
