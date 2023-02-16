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
    }
}
