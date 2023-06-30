using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Book {

        public string title;
        public string author;
        public int pages;

        // *** Constructor ***
        // Method in the class which gets called when an object is made
        public Book(string aTitle, string aAuthor, int aPages) {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }

    }
}
