using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    class Audi : Car
    {
        public string Model { get; set; }

        private string Brand = "Audi";

        public Audi(int hp, string colour, string model)
        {
            this.HP = hp;
            this.Colour = colour;
            this.Model = model;
        }
        public void ShowDeatils()
        {
            Console.WriteLine("Brand: {0}, Model: {1}, Colour: {2}, HP: {3}", Brand, Model, Colour, HP);
        }

        public override void Repair()
        {
            Console.WriteLine("Audi {0} was repaired", Model);
        }

    }
}
