using System;
using System.Collections;

namespace UniversityManagementSystem
{
    public class Course
    {
        private String name;
        private String id;
        private ArrayList section;

        public Course()
        {
            section = new ArrayList();
        }

        public Course(string name, string id, ArrayList section)
        {
            this.name = name;
            this.id = id;
            this.section = section;
        }

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public ArrayList Section { get => section; set => section = value; }

        public void showCourseInfo()
        {
            Console.WriteLine("Course Name : " + this.Name);
            Console.WriteLine("Course ID : " + this.Id+"\n");

            if(Section == null || Section.Count == 0)
            {
                Console.WriteLine("No Section");
            }
            else
            {
                Console.WriteLine("Total number of section : "+Section.Count+"\n");
                foreach (Section section in Section)
                {
                    section.showInfo();
                    Console.WriteLine();
                }
            }
        }
    }
}
