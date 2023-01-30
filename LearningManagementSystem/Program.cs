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
                    courseMenu(courses);
                }
                if (choiceInt == 2)
                {
                    Console.Clear();
                    studentMenu(students);
                }
                if (choiceInt == 3)
                {
                    return false;
                }
            }
            return true;
        }
        static void courseMenu(List<Course> courses)
        {
            bool navCourseMenu = true;

            while (navCourseMenu)
            {
                Console.WriteLine("Course Options");
                Console.WriteLine("1. Create course."); // DONE
                Console.WriteLine("2. Search for course by name or description"); // 
                Console.WriteLine("3. Update a course's information."); // DONE
                Console.WriteLine("4. List all courses"); // DONE
                Console.WriteLine("5. Create assignment for a specific course."); //
                Console.WriteLine("6. Go back to main menu");

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
                        
                    }
                    else if (choiceInt == 3) // update a course's information
                    {
                        Course.UpdateInfo(courses);   
                    }
                    else if (choiceInt == 4) // List
                    {
                        //Console.Clear();
                        Course.ListSelect(courses, 0);
                    }

                    else if (choiceInt == 5) // create assignment
                    {

                    }

                    if (choiceInt == 6)
                    {
                        navCourseMenu = false;
                    }
                }
            }
        }

        static void studentMenu(List<Person> students)
        {

        }


    }
}