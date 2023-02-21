using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Models
{
    public class Assignment
    {
        private string _name;
        private string _description;
        private string _totalAvailablePoints;
        private string _dueDate;

        public Assignment()
        {

        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
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
                return _totalAvailablePoints;
            }

            set
            {
                _totalAvailablePoints = value;
            }
        }

        public string DueDate
        {
            get
            {
                return _dueDate;
            }

            set
            {
                _dueDate = value;
            }
        }

        public override string ToString()
        {
            return "Assignment Name : " + _name + " | Assignmnet Description: " + _description + 
                " | Total Points: " + _totalAvailablePoints;
        }



    }
}
