using System;
using System.Collections;

namespace UniversityManagementSystem
{
    public class Section
    {
        private String name;
        private String id;
        private int duration;
        private ArrayList faculty;

        public Section()
        {
            faculty = new ArrayList();
        }

        public Section(string name, string id, int duration, ArrayList faculty)
        {
            this.Name = name;
            this.Id = id;
            this.Duration = duration;
            this.Faculty = faculty;
        }

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public int Duration { get => duration; set => duration = value; }
        public ArrayList Faculty { get => faculty; set => faculty = value; }
    }
}
