using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem
{
    internal class Course
    {
        //fields
        private string _code;
        private string _name;
        private string _description;
        private List<Person> _roster;
        private List<Assignment> _assignments;
        private List<Module> _modules;
        public string Code // property that exposes _code field.
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }

        public string Name // property that exposes _name field.
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Description // property that exposes _description field.
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public List<Person> Roster // property that exposes _roster field.
        {
            get
            {
                return _roster;
            }
        }
        public Course()
        {

        }

        static public Course AddCourse()
        {
            Course newCourse = new Course();

            Console.WriteLine("Enter code for the course.");
            string newCourseCode = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Enter name for the course.");
            string newCourseName = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Enter description for the course.");
            string newCourseDesc = Console.ReadLine() ?? string.Empty;
            newCourse.Code = newCourseCode;
            newCourse.Name = newCourseName;
            newCourse.Description = newCourseDesc;
            Console.Clear();
            return newCourse;
        }
       static public Course UpdateInfo(List<Course> courses)
        {
            
            int courseIndex = ListSelect(courses, 1);
            //Console.WriteLine(courses[courseIndex].Code);
            Console.WriteLine("What would you like to update about the course?");
            Console.WriteLine("1. Course Code");
            Console.WriteLine("2. Course Name");
            Console.WriteLine("3. Course Description");

            string choice = Console.ReadLine() ?? string.Empty;
            
            if (int.TryParse(choice, out int choiceInt))
            {
                if (choiceInt == 1)
                {
                    Console.Write("Please enter the updated course code: ");
                    string updatedCourseCode = Console.ReadLine() ?? string.Empty;
                    courses[courseIndex].Code = updatedCourseCode;
                }
                else if (choiceInt == 2)
                { 
                    Console.Write("please enter the updated course name: ");
                    string updatedCourseName = Console.ReadLine() ?? string.Empty;
                    courses[courseIndex].Name = updatedCourseName;
                }
                else if (choiceInt == 3)
                {
                    Console.Write("Please enter the updates course description: ");
                    string updatedCourseDesc = Console.ReadLine() ?? string.Empty;
                    courses[courseIndex].Description = updatedCourseDesc;
                }
            }
            return new Course();
        }
        public static int ListSelect(List<Course> courses, int option)
        {
            if (option == 0)
            { Console.WriteLine("Select a course to look at."); }
            else
            { Console.WriteLine("Select a course to change."); }

            int i = 1;
            foreach (var course in courses)
            {
                Console.WriteLine(i + ": " + course.Code);
                i++;
            }
            string choice = Console.ReadLine() ?? string.Empty;
            Console.Clear();
            if (option == 0 && int.Parse(choice) < i)
            {   
                Console.WriteLine(courses[int.Parse(choice) - 1]);
            }
            else
            {
                return int.Parse(choice)-1;
            }
            return 0;
        }

        public override string ToString()
        {
            return "Course Code : " + _code + " | Course Name: " + _name + " | Course Description: " + _description;
        }
    }
}
