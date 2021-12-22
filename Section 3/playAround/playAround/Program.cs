using System;
using System.Collections;

namespace playAround
{
    class Program
    {


        static void Main(string[] args)
        {

            /*Human Calum = new Human("Calum", "Wilson", "Brown", 21);
            Calum.introduction();*/


            /*Box box = new Box();
            box.Height = 4;
            box.Width = 5;

            box.Displayinfo();
            box.SetLength(2);
            box.GetLength();
            Console.WriteLine(box.FrontSurface); */


            /*Member newMember = new Member();

            Console.WriteLine("=========================");
            Console.WriteLine("Please enter first name: ");
            newMember.FirstName = Console.ReadLine();

            Console.WriteLine("Please enter LastName: ");
            newMember.LastName = Console.ReadLine();

            Console.WriteLine("Please enter JobTitle: ");
            newMember.JobTitle = Console.ReadLine();

            Console.WriteLine("Please enter age: ");
            newMember.Age = Console.ReadLine();

            newMember.MemberName = newMember.FirstName + newMember.LastName;

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", newMember.FirstName, newMember.LastName, newMember.JobTitle, newMember.Age, newMember.MemberName);


            Console.WriteLine("=========================");*/

            // jagged arrays; 

            string[][] jaggedArray = new string[3][];

            jaggedArray[0] = new string[] { "t1", "t2", "t3" };
            jaggedArray[1] = new string[] { "t1", "t2", "t3", "t4" };
            jaggedArray[2] = new string[] { "t1", "t2", "t3" };

            // Console.WriteLine("{0}", jaggedArray[2][2]);


            // print out jagged array;
            for(int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine("Row {0}", i);
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine("{0}", jaggedArray[i][j]);
                }
            }

            int minValue = MinimumValue(2, 12, 43, 23, 67, 134, 1234);
            Console.WriteLine("Minimum Value: {0}", minValue);

            int maxValue = MaximumValue(2, 12, 43, 23, 67, 134, 1234);
            Console.WriteLine("Maximum value: {0}", maxValue);


            // array lists
            ArrayList newArrayList = new ArrayList();

            newArrayList.Add(24);
            newArrayList.Add("Test");
            newArrayList.Add(123);

            // count the number of elements in the arrayList;
            Console.WriteLine("the number of elements in this array {0}", newArrayList.Count);


            // Remove from array list; 
            newArrayList.Remove("Test");

            // Count again;
            Console.WriteLine("the number of elements in this array {0}", newArrayList.Count);


            foreach(var element in newArrayList)
            {
                Console.WriteLine("output from array list {0}", element);
            }

        }

        // params   
        public static int MinimumValue(params int[] numbers)
        {
            int min = int.MaxValue;
            
            foreach(int number in numbers)
            {
                if(number < min)
                {
                    min = number;
                }

            }
            return min;
        }

        public static int MaximumValue(params int[] numbers)
        {
            int max = int.MinValue;

            foreach(int number in numbers)
            {
                if(number > max)
                {
                    max = number;
                }
            }
            
            return max;
        }


        
    }
}
