using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    class m3 : BMW
    {
        public m3(int hp, string colour, string model): base(hp, colour, model)
        {
            this.Model = model;
        }

        public override void Repair()
        {
            base.Repair();
        }
    }
}
