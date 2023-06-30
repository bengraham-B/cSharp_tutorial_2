using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethodsAndClasses {
    internal class UsefulTools {
        // Static methods, nneds 'public' to use the method below direcly WITHOUT creating an instance of the class
        public static void SayHi(string name) {
            Console.WriteLine("Hello " + name);
        }
    }
}
