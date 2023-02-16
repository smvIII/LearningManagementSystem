using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Models.Items
{
    public class FileItem : ContentItem
    {
        private string _filepath;

        public string FilePath
        {
            get { return _filepath; }
            set { _filepath = value; }
        }
    }
}
