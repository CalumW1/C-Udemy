using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
     class BMW : Car
    {
        public string Model { get; set; }

        private string Brand = "BMW";

        public BMW(int hp, string colour, string model)
        {
            this.Colour = colour;
            this.HP = hp;
            this.Model = model;
        }

        public void ShowDeatils()
        {
            Console.WriteLine("Brand: {0}, Model: {1}, Colour: {2}, HP: {3}", Brand, Model, Colour, HP);
        }

        public override void Repair()
        {
            Console.WriteLine("BMW {0} was repaired", Model);
        }

    }
}
