using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // The ItalianChef class can inherit from Chef class
    // " : Chef " This indicates that the Italian Chef Class is inheriting from the Chef class
    class ItalianChef : Chef {

        public void MakePasta() {
            Console.WriteLine("The chef can make pasta");
        }

        // Overding the "MakeSpecialDish()" method from the Chef class
        // Virtual -> Means that this method can be overriden in any subclass
        //  override -> replaces virtual, as you are overriding the function
        public override void MakeSpecialDish() {
            Console.WriteLine("The Chef can make Spahgetti ribs");
        }


    }
}
