using System;
using System.Collections.Generic;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            // add an element to the stack
            stack.Push(1);

            // Peek() will return the element at the top of the stack without removing it
            Console.WriteLine("Top value in the stack is {0}", stack.Peek());

            // push a bunch of items to the stack
            stack.Push(2);
            Console.WriteLine("Top value in the stack is {0}", stack.Peek());
            stack.Push(3);
            Console.WriteLine("Top value in the stack is {0}", stack.Peek());
            stack.Push(4);
            // remove from stack
            /*int stackINT = stack.Pop();
            Console.WriteLine("Pop Test {0}", stackINT);*/

            // using while loop to remove from stack

            while(stack.Count > 0)
            {
                int stackINT = stack.Pop();
                Console.WriteLine("Pop Test {0}", stackINT);
            }

            Console.WriteLine();
            Console.WriteLine();
            // return array in reverse order

            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };

            Stack<int> myStack = new Stack<int>();

            //insert numbers from the array into the stack
            for(int i = 0; i < numbers.Length; i++)
            {
                myStack.Push(numbers[i]);
            }

            // return the stack in reverse order;
            foreach(int number in myStack)
            {
                Console.WriteLine("{0}", number);
            }
        }
    }
}
