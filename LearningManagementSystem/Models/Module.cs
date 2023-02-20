using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningManagementSystem.Models.Items;
using LearningManagementSystem.Models.People;

namespace LearningManagementSystem.Models
{
    public class Module
    {
        private string ?_name;
        private string ?_description;
        private List<ContentItem> ?_content;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public List<ContentItem> Content
        {
            get { return _content; }
            set { _content = value; }
        }
        public static int ListSelect(List<Module> modules, int option) // 0 = no choice // 1 = choice
        {
            //Console.WriteLine("Here is a list of all students");
            int i = 1;
            foreach (var module in modules)
            {
                Console.Write(i + ": ");
                Console.WriteLine(module);
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

        public static void CreateItem(List<Module> modules, int moduleIndex)
        {
            Console.WriteLine("Please select what kind of item you want to create");
            Console.WriteLine("1. PageItem");
            Console.WriteLine("2. AssignmentItem");
            Console.WriteLine("3. FileItem");

            string choice = Console.ReadLine() ?? string.Empty;
            if (int.TryParse(choice, out int choiceInt))
            {
                if (choiceInt == 1 )
                {
                    PageItem newPageItem = new PageItem();
                    modules[moduleIndex].Content.Add(newPageItem);
                }
                else if (choiceInt == 2 )
                {
                    AssignmentItem newAssignmentItem = new AssignmentItem();
                    modules[moduleIndex].Content.Add(newAssignmentItem);
                }
                else
                {
                    FileItem newFileItem = new FileItem();
                    modules[moduleIndex].Content.Add(newFileItem);
                }
            }
            Console.WriteLine("Item added!");
        }
        public static void printModuleMenu()
        {
            Console.WriteLine("Module Options");
            Console.WriteLine("1. Create a module for a course."); // DONE 
            Console.WriteLine("2. Create an item for a module.");  // 
            Console.WriteLine("3. Update an item for a module.");  //
            Console.WriteLine("4. List modules for a course."); // DONE
            Console.WriteLine("5. Read an item's contents from a module.");
            Console.WriteLine("6. Remove an item from a module.");
            Console.WriteLine("7. Go back to main menu.");
        }
        public override string ToString()
        {
            return "Module Name : " + _name + " | Module Description: " + _description;
        }

    }
}
