using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LearningManagementSystem.Models.People;

namespace LearningManagementSystem.Models
{
    public class Course
    {
        //fields
        private int _creditHours;
        private string _code;
        private string _name;
        private string _description;
        private List<Person> _roster;
        private List<Assignment> _assignments;
        private List<Module> _modules;

        public Course()
        {
            _roster = new List<Person>();
            _assignments = new List<Assignment>();
            _modules = new List<Module>();
        }
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
            set { _roster = value; }
        }

        public List<Assignment> Assignments
        {
            get
            {
                return _assignments;
            }
            set { _assignments = value; }
        }
        public List<Module> Modules
        {
            get { return _modules; }
            set { _modules = value; }
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

        static public Assignment CreateAssignment()
        {
            Assignment newAssignment = new Assignment();

            Console.WriteLine("Please enter name for the assignment");
            string newAssignmentName = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Please enter description for the assignment");
            string newDescriptName = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Please enter the total available points for the assignment");
            string newTotalAvailPoints = Console.ReadLine() ?? string.Empty;
            newAssignment.Name = newAssignmentName;
            newAssignment.Description = newDescriptName;
            newAssignment.TotalAvailablePoints = newTotalAvailPoints;
            Console.Clear();
            return newAssignment;
            //Course._assignments.Add(newAssignment);
            //return newAssignment;
        }

        static public Module CreateModule()
        {
            Module newModule = new Module();
            Console.WriteLine("Please enter name for the module");
            string newModuleName = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Please enter description for module");
            string newModuleDesc = Console.ReadLine() ?? string.Empty;
            newModule.Name = newModuleName;
            newModule.Description = newModuleDesc;
            Console.Clear();
            return newModule;
        }

        static public void AddAssignment(Assignment newAssignment, List<Course> courses, int courseIndex)
        {
            courses[courseIndex].Assignments.Add(newAssignment);
        }

        public void printAssignments()
        {
            for (int i = 0; i < Assignments.Count; i++)
            {
                Console.WriteLine("Assignment " + i + ": " + Assignments[i].Name);
            }
        }
        static public Course UpdateCourse(List<Course> courses)
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
            else if (option == 1)
            { Console.WriteLine("Select a course to update."); }
            else if (option == 2)
            {
                Console.WriteLine("Select a course to add assignment to");
            }
            else if (option == 3)
            {
                Console.WriteLine("Select a course to add a module to");
            }

            int i = 1;
            foreach (var course in courses)
            {
                Console.WriteLine(i + ": " + course.Name + " - " + course.Code);
                i++;
            }
            string choice = Console.ReadLine() ?? string.Empty;
            Console.Clear();
            if (option == 0 && int.Parse(choice) < i) // just look at course
            {
                Console.WriteLine(courses[int.Parse(choice) - 1]);
            }
            else
            {
                return int.Parse(choice) - 1; // return choice to update
            }
            return 0;
        }

        public static void AddStudentToCourse(List<Person> students, List<Course> courses)
        {
            Console.WriteLine("Please select a course to add a student to.");
            int courseIndex = ListSelect(courses, -1);
            Console.WriteLine("Please select a student to add to that course.");
            int studentIndex = Person.ListSelect(students, 1);
            courses[courseIndex].Roster.Add(students[studentIndex]);
            courses[courseIndex].PrintCourseStudents();
            Console.Clear();

        }

        public static void RmStudentFromCourse(List<Person> students, List<Course> courses)
        {
            Console.WriteLine("Please select a course to remove a student from.");
            int courseIndex = ListSelect(courses, -1);
            Console.WriteLine("Please select a student to remove from course.");
            int studentIndex = Person.ListSelect(students, 1);
            courses[courseIndex].Roster.Remove(students[studentIndex]);
            courses[courseIndex].PrintCourseStudents();

        }

        public void PrintCourseStudents()
        {
            Console.WriteLine("Updated " + Name + " roster.");
            for (int i = 0; i < Roster.Count; i++)
            {
                Console.WriteLine(Name + ": " + Roster[i].Name);
            }
        }

        public static void CourseSearch(List<Course> courses)
        {
            Console.WriteLine("Please enter name or description of course to search:");

            string query = Console.ReadLine() ?? string.Empty;

            // modeled from youtube video "Ep 11. Adding search functionality for courses" by Chris Mills
            courses.Where(s => s.Name.ToUpper().Contains(query.ToUpper())
                || s.Description.ToLower().Contains(query.ToLower())).ToList()
                .ForEach(Console.WriteLine);
        }

        public static void printCourseMenu()
        {
            Console.WriteLine("Course Options");
            Console.WriteLine("1. Create course."); // DONE
            Console.WriteLine("2. Search for course by name or description."); // DONE
            Console.WriteLine("3. Update a course's information."); // DONE
            Console.WriteLine("4. List all courses."); // DONE
            Console.WriteLine("5. Create assignment for a specific course."); // DONE
            Console.WriteLine("6. Add student from list to specific course."); // DONE
            Console.WriteLine("7. Remove student from list to specific course."); // DONE
            Console.WriteLine("8. Go back to main menu"); // DONE

        }
        public override string ToString()
        {
            return "Course Code : " + _code + " | Course Name: " + _name + " | Course Description: " + _description;
        }
    }
}
