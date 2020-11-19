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
    }
}
