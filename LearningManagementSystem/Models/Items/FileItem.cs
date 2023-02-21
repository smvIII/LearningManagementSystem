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

        public static FileItem CreateFileItem()
        {
            FileItem newFileItem  = new FileItem();
            
            Console.WriteLine("Please enter a name for the the FileItem.");
            string newFileItemName = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Please enter description for the FileItem.");
            string newFileItemDesc = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Please enter filepath for the FileItem.");
            Console.WriteLine(@"Format: C:\\Users\\*USERNAME*\\Documents\\*FILENAME*");
            string newFileItemFilePath = Console.ReadLine() ?? string.Empty;
            
            newFileItem.FilePath = newFileItemFilePath;
            newFileItem.Name = newFileItemName;
            newFileItem.Description = newFileItemDesc;
            newFileItem.Type = "FileItem";

            return newFileItem;
        }



    }
}
