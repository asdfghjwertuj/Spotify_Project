using System;

namespace ExamTeamProject
{ 
    public struct Track
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime DateOfAdd { get; set; }
        public TimeSpan Duration { get; set; }
        public Track(string name, string author, DateTime dateOfAdd, TimeSpan duration)
        {
            Name = name;
            Author = author;
            DateOfAdd = dateOfAdd;
            Duration = duration;
        }
    }
}
