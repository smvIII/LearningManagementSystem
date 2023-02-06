using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem
{
    internal class Module
    {
        private string _name;
        private string _description;
        private List<ContentItem> _content;

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
    }
}
