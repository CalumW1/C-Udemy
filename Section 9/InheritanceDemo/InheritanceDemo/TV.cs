using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class TV : Device
    {
        
        public TV(bool isOn, string brand):base(isOn, brand)
        {
        }

        public void WatchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching TV!");
            }
            else
            {
                Console.WriteLine("TV is switched off, swtich it on first"); 
            }
        }
    }
}
