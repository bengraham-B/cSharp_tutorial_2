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

        public Song(string aTitle, string aArtist, int aDuration) {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
        }
    }
}
