using System;
using System.Collections;
namespace UniversityManagementSystem
{
    public class Faculty
    {
        private String name;
        private String id;
        private ArrayList section;

        public Faculty()
        {
            section = new ArrayList();
        }

        public Faculty(string name, string id, ArrayList section)
        {
            this.Name = name;
            this.Id = id;
            this.Section = section;
        }

        public Faculty(string name, string id)
        {
            this.Name = name;
            this.Id = id;
            section = new ArrayList();
        }

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public ArrayList Section { get => section; set => section = value; }

        public void showInfo()
        {
            Console.WriteLine("Faculty Name : " + this.Name);
            Console.WriteLine("Faculty ID : " + this.Id);
        }

        public int loadInWeek()
        {
            int load = 0;

            foreach(Section section in this.Section)
            {
                load += section.Duration * section.NClassInWeek;
            }

            return load;
        }
    }
}
