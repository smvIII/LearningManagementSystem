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

        
        public static AssignmentItem CreateAssignmentItem(List<Course>courses, int courseIndex)
        {
            AssignmentItem newAssignmentItem = new AssignmentItem();

            Console.WriteLine("Please enter a name for the the AssignmentItem.");
            string newAssignmentItemName = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Please enter description for the AssignmentItem.");
            string newAssignmentItemDesc = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Please select an assignment to add to the module");
            int assignmentIndex = Services.ListSelect(courses[courseIndex].Assignments, 1);
            Assignment newAssignmentItemAssignment = courses[courseIndex].Assignments[assignmentIndex];

            newAssignmentItem.Assignment = newAssignmentItemAssignment;
            newAssignmentItem.Name = newAssignmentItemName;
            newAssignmentItem.Description = newAssignmentItemDesc;
            newAssignmentItem.Type = "AssignmentItem";

            return newAssignmentItem;

        } 
      
    }
}
