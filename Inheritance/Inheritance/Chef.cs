using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Chef {
        // Three methods the Chef class can use.
        public void MakeChicken() {
            Console.WriteLine("The Chef can make chicken");
        }

        public void MakeSalad() {
            Console.WriteLine("The Chef can make Salad");
        }

        // Virtual -> Means that this method can be overriden in any subclass
        public virtual void MakeSpecialDish() {
            Console.WriteLine("The Chef can make BBQ ribs");
        }
    }
}
