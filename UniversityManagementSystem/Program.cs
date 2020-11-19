using System;
using System.Collections;

namespace UniversityManagementSystem
{
    class Program
    {
        public int userInput()
        {
            Console.WriteLine("\nEnter Option : ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public Boolean addCourse(Department dept,Course course)
        {
            if(dept != null && dept.Courses != null)
            {
                dept.Courses.Add(course);
                return true;
            }
            else{
                return false;
            }
        }

        public Boolean addSection(Course course, Section section)
        {
            if(course != null && course.Section != null)
            {
                course.Section.Add(section);
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean assignFaculty(Section section, Faculty faculty)
        {
            if(faculty.loadInWeek()+(section.Duration*section.NClassInWeek) > 21)
            {
                return false;
            }
            else
            {
                if(section!= null && faculty.Section != null)
                {
                    section.Faculty = faculty;
                    faculty.Section.Add(section);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void modifyMenu()
        {
            Console.WriteLine("1. Add Section");
            Console.WriteLine("2. Assign Faculty to Section");
            Console.WriteLine("0. Exit");
        }
        static void Main(string[] args)
        {
            //    Section asec = new Section();
            //    Section bsec = new Section();

            //    asec.Name = "OOP2 H";
            //    asec.Id = "2133";
            //    asec.Duration = 2;
            //    Faculty fac = new Faculty();
            //    fac.Name = "Shazzad Hossain";
            //    fac.Id = "4231";
            //    fac.Section = asec;
            //    asec.Faculty.Add(fac);
            //
            Program p = new Program();

            Department cse = new Department();
            cse.Name = "Computer Science and Engineering";
            cse.Id = "101";

            Department eee = new Department();
            eee.Name = "Electrical & Electronics Engineering";
            eee.Id = "102";

            Department bba = new Department();
            bba.Name = "Bachelor of Business Administration";
            bba.Id = "103";

            Faculty sazzad = new Faculty("Sazzad Hossain", "1012");
            Faculty mishu = new Faculty("Mahbub Chowdhury Mishu", "1013");
            Faculty tanveer = new Faculty("Tanvir Ahmed", "1016");
            Faculty hasib = new Faculty("Hasib Hasan", "1014");
            Faculty viktor = new Faculty("Viktor Stanny Rozario", "1015");

            Section oop1A = new Section("A", "6685", 1,3, sazzad);
            Section oop2A = new Section("A", "9865", 1, 3, tanveer);
            Section oop2B = new Section("B", "9865", 1, 3, sazzad);
            Section oop2C = new Section("C", "9865", 1, 3, tanveer);
            Section oop1B = new Section("B", "4825", 1, 3, viktor);
            Section webtechA = new Section("A", "5698", 1, 3, mishu);
            Section webtechB = new Section("B", "5699", 1, 3, hasib);
            Section webtechC = new Section("C", "5697", 1, 3, viktor);

            Course oop1 = new Course("Object Oriented Programming 1", "", new ArrayList { oop1A, oop1B });
            Course oop2 = new Course("Object Oriented Programming 2", "", new ArrayList { oop2A, oop2B, oop2C });
            Course webtech = new Course("Web Technology", "", new ArrayList { webtechA, webtechB, webtechC });

            cse.Courses = new ArrayList { oop1,oop2,webtech};

            //oop1.showCourseInfo();
            //oop2.showCourseInfo();
            //webtech.showCourseInfo();

            /*sazzad.showInfo();
            Console.WriteLine();
            foreach(Section section in sazzad.Section)
            {
                section.showInfo();
            }*/

            Department[] departments = {cse,eee,bba };
            Faculty[] faculties = { sazzad,mishu,tanveer,hasib,viktor};

            while (true)
            {
                Console.WriteLine("University Management System");
                Console.WriteLine("============================\n\n");
                Console.WriteLine("Departments:\n");
                int c = 0;
                foreach (Department department in departments)
                {
                    Console.Write(++c + ". ");
                    Console.WriteLine(department.Name);
                }
                Console.WriteLine("0. Exit");


                int opt = p.userInput();

                if (opt == 0)
                {
                    break;
                }
                else
                {
                    Department dept = departments[opt - 1];

                    Console.WriteLine("\n" + dept.Name);
                    Console.WriteLine("\nCourses:\n");
                    dept.showCourses();
                    Console.WriteLine("0. Add Course");

                    opt = p.userInput();

                    if (opt == 0)
                    {
                        Console.WriteLine("New Course:\n");
                        Console.WriteLine("Course Name :");
                        String name = Console.ReadLine();
                        Console.WriteLine("Course ID :");
                        String id = Console.ReadLine();

                        if(p.addCourse(dept, new Course(name, id)))
                        {
                            Console.WriteLine(name+" course added successfully");
                        }
                        else
                        {
                            Console.WriteLine("Course add failed");
                        }
                    }
                    else
                    {
                        Course course = (Course)dept.Courses[opt - 1];
                        course.showCourseInfo();
                        p.modifyMenu();
                        opt = p.userInput();

                        if (opt == 1)
                        {
                            Console.WriteLine("Add Section");
                            Console.WriteLine("Section Name : ");
                            String name = Console.ReadLine();
                            Console.WriteLine("Section ID : ");
                            String id = Console.ReadLine();
                            Console.WriteLine("Section ID : ");
                            int duration = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Section ID : ");
                            int numberOfClass = Convert.ToInt32(Console.ReadLine());

                            if (p.addSection(course, new Section(name, id,duration,numberOfClass)))
                            {
                                Console.WriteLine(name + " section added successfully");
                            }
                            else
                            {
                                Console.WriteLine("Section add failed");
                            }
                        }
                        else if(opt == 2)
                        {
                            Console.WriteLine("Sections with no faculty");
                            ArrayList noFaculty = new ArrayList();
                            for(int i = 0; i < course.Section.Count; ++i)
                            {
                                Section section = (Section) course.Section[i];
                                if(section.Faculty == null)
                                {
                                    noFaculty.Add(section);
                                    section.showInfo();
                                }
                            }

                            opt = p.userInput();


                        }
                        else if(opt == 0)
                        {

                        }

                    }
                }

            
            }
        }
    }
}
