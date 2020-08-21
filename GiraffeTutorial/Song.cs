using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GiraffeTutorial
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount;

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;


        }
        public int getSongCount()
        {
            return songCount++;
        }


    }

}
