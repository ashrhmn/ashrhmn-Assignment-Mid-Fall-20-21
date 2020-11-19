using System;

namespace UniversityManagementSystem
{
    public class Section
    {
        private String name;
        private String id;
        private int duration;
        private int nClassInWeek;
        private Faculty faculty;

        public Section()
        {
            faculty.Section.Add(this);
        }

        public Section(string name, string id, int duration, int nClassInWeek, Faculty faculty)
        {
            this.Name = name;
            this.Id = id;
            this.Duration = duration;
            this.nClassInWeek = nClassInWeek;
            faculty.Section.Add(this);
            this.Faculty = faculty;
        }
        public Section(string name, string id, int duration, int nClassInWeek)
        {
            this.Name = name;
            this.Id = id;
            this.Duration = duration;
            this.nClassInWeek = nClassInWeek;
        }

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public int Duration { get => duration; set => duration = value; }
        public Faculty Faculty { get => faculty; set => faculty = value; }
        public int NClassInWeek { get => nClassInWeek; set => nClassInWeek = value; }

        public void showInfo()
        {
            Console.WriteLine("Section Name : " + this.Name);
            Console.WriteLine("Section ID : " + this.Id);
            Console.WriteLine("Class Duration : " + this.Duration + " hour");
            this.Faculty.showInfo();
        }
    }
}
