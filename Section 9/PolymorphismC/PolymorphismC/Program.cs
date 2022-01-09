using System;
using System.Collections.Generic;

namespace PolymorphismC
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new Audi(200, "blue", "A4"),
                new BMW(250, "Red", "M3")
            };

            foreach(var car in cars)
            {
                car.Repair();
            }

            m3 myM3 = new m3(20, "green", "m3 competition");
            myM3.Repair();

            Car bmw2series = new BMW(200, "black", "2 series");

            bmw2series.SetCarIDInfo(1234234, "calum");

            bmw2series.getCarIDInfo();

            Console.ReadKey();

        }
    }
}
