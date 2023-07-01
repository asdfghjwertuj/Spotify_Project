using System;

namespace ExamTeamProject
{ 
    public struct Track
    {
        public string Name { get; set; }
        public string Executor { get; set; }
        public DateTime DateOfAdd { get; set; }
        public TimeSpan Duration { get; set; }
        public Track(string name, string executor, DateTime dateOfAdd, TimeSpan duration)
        {
            Name = name;
            Executor = executor;
            DateOfAdd = dateOfAdd;
            Duration = duration;
        }
    }
}
