using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningManagementSystem.Models.Items;

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
        public static void printModuleMenu()
        {
            Console.WriteLine("Module Options");
            Console.WriteLine("1. Create a module for a course.");
            Console.WriteLine("2. Create an item for a module.");
            Console.WriteLine("3. Update an item for a module.");
            Console.WriteLine("4. Read an item's contents from a module.");
            Console.WriteLine("5. Remove an item from a module.");
            Console.WriteLine("6. Go back to main menu.");
        }
    }
}
