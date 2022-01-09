using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    public class Car
    {
        public int HP { get; set; }

        public string Colour { get; set; }

        // has a relationship;
        private protected CarIDinfo carIDinfo = new CarIDinfo();

        public void SetCarIDInfo(int idNum, string Owner)
        {
            carIDinfo.ID = idNum;
            carIDinfo.owner = Owner;
        }

        public void getCarIDInfo()
        {
            Console.WriteLine("The car has the ID of {0} and is owned by {1}", carIDinfo.ID.ToString(), carIDinfo.owner.ToString());
        }

        // default;
        public Car()
        {
            HP = 100;
            Colour = "Black";
        }

        public Car(int hp, string colour)
        {
            this.Colour = colour;
            this.HP = hp; 
        }

        // return the colour and health of the car to the console.
        public void ShowDetails()
        {
            Console.WriteLine("Colour: {0}, HP: {1}", Colour, HP);
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired");
        }
    }
}
