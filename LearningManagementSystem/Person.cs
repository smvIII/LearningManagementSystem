using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem
{
    internal class Person
    {
        private string _name;
        private string _classification;
        private List<int> _grades;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Classification
        { get { return _classification; } set { _classification = value; } }

        public List<int> Grades
        {
            get { return _grades; }
            set { _grades = value; }
        }

    }
}
