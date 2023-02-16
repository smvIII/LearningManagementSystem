using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Models.Items
{
    public class AssignmentItem : ContentItem
    {
        private Assignment _assignment;

        public Assignment Assignment
        {
            get { return _assignment; }
            set { _assignment = value; }
        }


    }
}
