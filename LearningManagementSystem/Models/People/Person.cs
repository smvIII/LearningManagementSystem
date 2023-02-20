using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
    
namespace LearningManagementSystem.Models.People
{
    public class Person
    {
        private string _name;
        private string _classification;
        private List<int> _grades;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Classification
        {
            get { return _classification; }
            set { _classification = value; }
        }

        public List<int> Grades
        {
            get { return _grades; }
            set { _grades = value; }
        }

        static public Person AddStudent()
        {
            Person newStudent = new Person();

            Console.WriteLine("Enter name for student.");
            string newStudentName = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Enter Classification of student.");
            string newClassification = Console.ReadLine() ?? string.Empty;
            //Console.WriteLine("Enter student's grades");
            //string newGrades = Console.ReadLine() ?? string.Empty;

            newStudent.Name = newStudentName;
            newStudent.Classification = newClassification;
            //newStudent.Grades = newGrades;
            Console.Clear();
            return newStudent;

        }

        static public void UpdateStudent(List<Person> students)
        {
            Console.WriteLine("Select a student to update");
            int studentIndex = ListSelect(students, 1);
            Console.WriteLine("What would you like to update about the student?");
            Console.WriteLine("1. Name");
            Console.WriteLine("2. Classification");
            //Console.Clear();
            //Console.WriteLine("3. Grades") not in assignment 1 requirements

            string choice = Console.ReadLine() ?? string.Empty;
            if (int.TryParse(choice, out int choiceInt))
            {
                if (choiceInt == 1)
                {
                    Console.WriteLine("Please enter the updated name: ");
                    string updatedName = Console.ReadLine() ?? string.Empty;
                    students[studentIndex].Name = updatedName;
                }
                if (choiceInt == 2)
                {
                    Console.WriteLine("Please enter updated classification: ");
                    string updatedClass = Console.ReadLine() ?? string.Empty;
                    students[studentIndex].Classification = updatedClass;
                }
                Console.Clear();
            }

        }

        public static int ListSelect(List<Person> students, int option) // 0 = no choice // 1 = choice
        {
            //Console.WriteLine("Here is a list of all students");
            int i = 1;
            foreach (var student in students)
            {
                Console.WriteLine(i + ": " + student.Name + " - " + student.Classification);
                i++;
            }
            if (option == 1)
            {
                string choice = Console.ReadLine() ?? string.Empty;
                return int.Parse(choice) - 1; // return choice
            }

            //Console.Clear()
            return 0;
        }

        public static void ListStudentCourses(List<Person> students, List<Course> courses)
        {
            Console.WriteLine("Please select a student to view their courses.");
            int studentIndex = ListSelect(students, 1);
            // Console.WriteLine("Course count is " + courses.Count);
            int courseCounter = 1;
            for (int i = 0; i < courses.Count; i++)
            {
                for (int j = 0; j < courses[i].Roster.Count; j++)
                {
                    if (students[studentIndex].Name == courses[i].Roster[j].Name)
                    {
                        Console.WriteLine("Course " + courseCounter + ": " + courses[i].Name);
                        courseCounter++;
                    }
                }
            }

        }

        public static void StudentSearch(List<Person> students)
        {
            Console.WriteLine("Please enter a name you would like to search for:");
            string query = Console.ReadLine() ?? string.Empty;

            // modeled from youtube video "Ep 6. Adding search functionality for students" by Chris Mills
            students.Where(s => s.Name.ToUpper().Contains(query.ToUpper())).ToList().ForEach(Console.WriteLine);


        }

        public static void printStudentMenu()
        {
            Console.WriteLine("Student Options."); //
            Console.WriteLine("1. Create a student."); // DONE
            Console.WriteLine("2. Search for a student."); // DONE
            Console.WriteLine("3. Update a student's info.");  // DONE
            Console.WriteLine("4. List all students."); // DONE
            Console.WriteLine("5. List all courses a student is taking."); //DONE
            Console.WriteLine("6. Go back to main menu."); // DONE
        }

        public override string ToString()
        {
            return _name + " - " + _classification;
        }

    }
}
