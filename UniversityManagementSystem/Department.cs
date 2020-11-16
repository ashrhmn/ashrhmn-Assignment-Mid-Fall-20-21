using System;
using System.Collections;
namespace UniversityManagementSystem
{
    public class Department
    {
        private String name;
        private String id;
        private ArrayList courses;

        public Department()
        {
        }

        public Department(string name, string id, ArrayList courses)
        {
            this.name = name;
            this.id = id;
            this.courses = courses;
        }

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public ArrayList Courses { get => courses; set => courses = value; }
    }
}
