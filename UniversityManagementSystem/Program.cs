using System;

namespace UniversityManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Test!");
            Section asec = new Section();

            asec.Name = "OOP2 H";
            asec.Id = "2133";
            asec.Duration = 2;
            Faculty fac = new Faculty();
            fac.Name = "Shazzad Hossain";
            fac.Id = "4231";
            fac.Section = asec;
            asec.Faculty.Add(fac);
        }
    }
}
