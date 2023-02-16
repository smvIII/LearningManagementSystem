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
    }
}
