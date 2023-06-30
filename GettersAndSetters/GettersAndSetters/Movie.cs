using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GettersAndSetters {
    internal class Movie {
        // public -> can be accessed by any other code.
        // private -> only code in the movie class can access the rating
        public string title;
        public string directory;
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating) {
            title = aTitle;
            directory = aDirector;
            rating = aRating;
        }

            // Getters & Setters will allow outside code (Code in Program.cs) to access and modiy and set the ratings
            // Getters & Setters can e defined through property. (Special Method)

            public string Rating {
            // Get will allow us to get the rating attribute
            get { return rating; }

            set {
                if (value == "G" || value == "PG-13" || value == "R") {
                    rating = value;  
                }
                else {
                    rating = "NR";
                }
                
            }
        }
   

        
    }
}
