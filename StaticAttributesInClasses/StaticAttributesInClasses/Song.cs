using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAttributesInClasses {
    internal class Song {

        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0; // This attribute belongs to the class, access it through class (Song.songCount)

        // Constructor, gets called when an object is created
        public Song(string aTitle, string aArtist, int aDuration) {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }

        // Method, accessing song count on each individual object
        public int getSongCount() {
            return songCount;

        }
    }
}
