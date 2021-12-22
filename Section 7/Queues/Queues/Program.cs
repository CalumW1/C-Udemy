using System;
using System.Collections.Generic;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Queue<int> queue = new Queue<int>();

            // add items to the queue;
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // display the item at the front of the queue;
            Console.WriteLine("Value at the start of the array {0} ", queue.Peek());

            // remove items from the queue; 
            queue.Dequeue();
            Console.WriteLine("Value at the start of the array {0} ", queue.Peek());

            while (queue.Count > 0)
            {
                Console.WriteLine("The value at the front of the queue is {0}", queue.Dequeue());

                Console.WriteLine("Queue count is {0}", queue.Count);
       
            }*/

            Queue<Order> ordersQueue = new Queue<Order>();

            foreach (Order orders in RevievedOrdersFromBranch1())
            {
                ordersQueue.Enqueue(orders);
            }

            foreach (Order orders in RevievedOrdersFromBranch2())
            {
                ordersQueue.Enqueue(orders);
            }
           
            while (ordersQueue.Count > 0)
            {
                Order currentOrder = ordersQueue.Dequeue();
                currentOrder.ProcessOrder();
            }
        }

        
        static Order[] RevievedOrdersFromBranch1()
        {
            Order[] orders = new Order[] 
            { 
                new Order(3, 5),
                new Order(4, 4),
                new Order(5, 10)
            };
            return orders;
        }

        static Order[] RevievedOrdersFromBranch2()
        {
            Order[] orders = new Order[]
            {
                new Order(1, 5),
                new Order(2, 4),
                new Order(6, 10)
            };
            return orders;
        }

    }

    class Order
    {
        public int OrderId { get; set; }

        public int OrderQuantity { get; set; }

        public Order(int id, int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderQuantity;
        }

        public void ProcessOrder()
        {
            Console.WriteLine("Order {0} processed!", OrderId);
        }
    }
}
