using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Models.Items
{
    public class PageItem : ContentItem
    {
        private string _htmlbody;

        public string HTMLBody
        {
            get { return _htmlbody; }
            set { _htmlbody = value; }
        }

        public static PageItem CreatePageItem()
        {
            PageItem newPageItem = new PageItem();
            
            Console.WriteLine("Please enter a name for the the PageItem.");
            string newPageItemName = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Please enter description for the PageItem.");
            string newPageItemDesc = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Please enter the filepath for the PageItem's HTML Body");
            Console.WriteLine("Format: C:\Users\*USERNAME*\Documents\*FILENAME*");
            string newPageItemFP = Console.ReadLine() ?? string.Empty;

            newPageItem.Name = newPageItemName;
            newPageItem.Description = newPageItemDesc;
            newPageItem.Path = newPageItemFP;

            
        }
    }
}
