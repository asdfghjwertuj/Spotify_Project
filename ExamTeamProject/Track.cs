using System;

namespace ExamTeamProject
{ 
    public struct Track
    {
        public string Name { get; set; }
        public DateTime DateOfAdd { get; set; }
        public TimeSpan Duration { get; set; }
        public Track(string name, DateTime dateOfAdd, TimeSpan duration)
        {
            Name = name;
            DateOfAdd = dateOfAdd;
            Duration = duration;
        }
    }
}
