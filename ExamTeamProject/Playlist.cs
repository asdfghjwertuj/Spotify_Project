using System.Collections.Generic;

namespace ExamTeamProject
{
    public class Playlist
    {
        public string Name { get; set; }
        public List<Track> Tracks { get; set; }
        public Playlist(string name)
        {
            Name = name;
            Tracks = new List<Track>();
        }
    }
}
