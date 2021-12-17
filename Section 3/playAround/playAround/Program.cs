using System;

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

            int[] numbers = { 12, 3123, 234, 2 };

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("{0}", numbers[i]);
            }

            string[] friends = { "test1", "test2", "test3", "test4" };

            for(int i = 0; i < friends.Length; i++)
            {
                Console.WriteLine("Hello {0}", friends[i]);
            }
        }
    }
}
