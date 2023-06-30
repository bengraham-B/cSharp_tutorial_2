using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PbjectMethod {
    internal class Student {

        public string name;
        public string major;
        public double gpa;

        public Student(string aName, string aMajor, double aGpa) {
            name = aName;
            major = aMajor;
            gpa = aGpa;

        }

        double honorsRequirement = 4.0;

        // Method which returns a boolean
        public bool hasHonors() {
            if(gpa >= honorsRequirement) {
                return true;
            }

            return false;
        }
    }
}
