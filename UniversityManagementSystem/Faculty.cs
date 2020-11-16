using System;
namespace UniversityManagementSystem
{
    public class Faculty
    {
        private String name;
        private String id;
        private Section section;

        public Faculty()
        {
        }

        public Faculty(string name, string id, Section section)
        {
            this.Name = name;
            this.Id = id;
            this.Section = section;
        }

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public Section Section { get => section; set => section = value; }
    }
}
