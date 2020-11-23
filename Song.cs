using System;
using System.Collections.Generic;
using System.Text;
using static Song.Program;

namespace Song
{
    public class Song
    {
        //properties
        public string Title { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }
        public Genre MusicGenre { get; set; }



        public Song(string title, string artist, double duration) :
            this(title, artist, duration)
        {

        }
        public Song() : this("","" ,0) 
        { 

        }
        public enum Genre
        {
            Rock,
            Pop,
            Dance,
            Other,
        }


        //title[string], artist[string], duration[double] and genre[Genre].
    }
}
