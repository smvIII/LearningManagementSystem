using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem
{
    internal class Assignment
    {
        private string _name;
        private string _description;
        private string _total_available_points;
        private string _due_date;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public string TotalAvailablePoints
        {
            get
            {
                return _total_available_points;
            }

            set
            {
                _total_available_points = value;
            }   
        }

        public string DueDate
        {
            get
            {
                return _due_date;
            }

            set
            {
                _due_date = value;
            }
        }
    }
}
