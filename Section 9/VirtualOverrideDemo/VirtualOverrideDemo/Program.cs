using System;

namespace VirtualOverrideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Mac", 6);
            Console.WriteLine("{0} is {1} years old", dog.Name, dog.Age);
            dog.MakeSounds();
            dog.Play();
            dog.Eat();

        }
    }
}
