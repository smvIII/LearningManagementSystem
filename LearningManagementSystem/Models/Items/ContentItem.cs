using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Models.Items
{
    public class ContentItem
    {
        private string _name;
        private string _description;
        private string _path;
        private string _type;

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

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public static void ShowContent(ContentItem item)
        {
            if (item.Type == "PageItem")
            {
                var pgItm = (PageItem)item;
                PageItem.PrintContent(pgItm);
            }
            else if (item.Type == "AssignmentItem")
            {
                var asItm = (AssignmentItem)item;
                Console.WriteLine(asItm.Assignment);

            }

        }

        public override string ToString()
        {
            return _name + " - " + _description + " - " + _path;
        }

    }
}
