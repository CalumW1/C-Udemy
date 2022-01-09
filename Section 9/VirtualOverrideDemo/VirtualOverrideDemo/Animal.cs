using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class Animal
    {
        // Implement a class, Name, age isHungry, constructor, makesounds, eat and play;

        public string Name { get; set; }
        
        public int Age { get; set; }

        public bool isHungry { get; set; }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.isHungry = true;
        }

        public virtual void MakeSounds()
        {
            
        }

        public virtual void Eat()
        {
            if (isHungry)
            {
                Console.WriteLine("{0} is eating", Name);
            }
            else
            {
                Console.WriteLine("{0} is not hungry", Name);
            }
        }

        public virtual void Play()
        {
            Console.WriteLine("{0} is playing", Name);
        }
    }
}
