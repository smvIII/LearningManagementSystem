using System;
using LearningManagementSystem;
using System.Reflection.PortableExecutable;

namespace cop4870
{
    internal class Assignment1
    {
        static void Main(string[] args)
        {
            bool navMainMenu = true;
            var courses = new List<Course>();
            var students = new List<Person>();

            while (navMainMenu)
            {
                navMainMenu = mainMenu(courses, students);
            }    
        }
        static bool mainMenu(List<Course> courses, List<Person> students)
        {
            Console.WriteLine("Welcome to the Learning Management System!");
            Console.WriteLine("Please select which menu you would like to navigate.");
            Console.WriteLine("1. Course Options");
            Console.WriteLine("2. Student Options");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine() ?? string.Empty;

            if (int.TryParse(choice, out int choiceInt))
            {
                if (choiceInt == 1)
                {

                    Console.Clear();
                    courseMenu(courses, students);
                }
                if (choiceInt == 2)
                {
                    Console.Clear();
                    studentMenu(students, courses);
                }
                if (choiceInt == 3)
                {
                    return false;
                }
            }
            return true;
        }
        static void courseMenu(List<Course> courses, List<Person> students)
        {
            bool navCourseMenu = true;

            while (navCourseMenu)
            {

                Course.printCourseMenu();
                string choice = Console.ReadLine() ?? string.Empty;
                Console.Clear();

                if (int.TryParse(choice, out int choiceInt))
                {
                    if (choiceInt == 1)
                    {
                        courses.Add(Course.AddCourse());
                    }
                    else if (choiceInt == 2) // queries or something
                    {
                        Course.CourseSearch(courses);
                    }
                    else if (choiceInt == 3) // update a course's information
                    {
                        Course.UpdateCourse(courses);   
                    }
                    else if (choiceInt == 4) // List
                    {
                       
                        Course.ListSelect(courses, 0);
                    }

                    else if (choiceInt == 5) // create assignment
                    {
                        Assignment newAssignment = Course.CreateAssignment();
                        int courseIndex = Course.ListSelect(courses, 2);
                        Course.AddAssignment(newAssignment, courses, courseIndex);
                        courses[courseIndex].printAssignments();
                    }

                    else if (choiceInt == 6) //add student from list of students and add to course
                    {
                        Course.AddStudentToCourse(students, courses);
                    }

                    else if (choiceInt == 7) // remove a student from a course's roster
                    {
                        Course.RmStudentFromCourse(students, courses);
                    }

                    else if (choiceInt == 8) // exit from course menu
                    {
                        navCourseMenu = false;
                    }
                }
            }
        }

        static void studentMenu(List<Person> students, List<Course> courses)
        {
            bool navStudentMenu = true;

            while (navStudentMenu)
            {
                Person.printStudentMenu();
                string choice = Console.ReadLine() ?? string.Empty;
                Console.Clear();

                if (int.TryParse(choice, out int choiceInt))
                {
                    if (choiceInt == 1) // Create a student
                    {
                        students.Add(Person.AddStudent());
                    }
                    else if (choiceInt == 2) //search for a student
                    {
                        Person.StudentSearch(students);
                    }
                    else if (choiceInt == 3) // update a students info
                    {
                        Person.UpdateStudent(students);
                    }
                    else if (choiceInt == 4) // list all students
                    {
                        Console.WriteLine("Here is a list of all enrolled students");
                        Person.ListSelect(students, 0);
                    }   
                    else if (choiceInt == 5) // list all courses a student is taking
                    {
                        Person.ListStudentCourses(students, courses);
                    }
                    else if (choiceInt == 6) // exit student menu
                    {
                        navStudentMenu = false;
                    }
                }

            }
        }


    }
}