using System;
using System.Collections.Generic;
using System.IO;

namespace UtilityClass
{
    
    class Utility
    {
        private string currentPath;
        private string DirectoryPath =@"./building/";

        public Utility(string currentPath)
        {
            this.currentPath = currentPath;
        }

        public string getFilePath(string app_no, string type)
        {
            string path;
            path = @$"{DirectoryPath}\{app_no}\{type}.txt";
            return path;
        }
        public void initializeFileStructure()
        {
                if (!Directory.Exists(DirectoryPath)) Directory.CreateDirectory(DirectoryPath);

                string[] lines = File.ReadAllLines(this.currentPath);
                string[] items;
                foreach (var line in lines)
                {
                    items = line.Split(",");
                if (items[0] == "AD")
                {
                    Directory.CreateDirectory(@$"{DirectoryPath}{items[1]}");
                   
                }
/*              
*/
            }


        }
        public void writeToFilePath(string path, string msg)
        {
         
                File.AppendAllText(path, $"{msg}\n");
            
           
        }
        public string[] readFromFilePath(string path)
        {
            if (File.Exists(path))
            {
                string[] lines= File.ReadAllLines(path);
                return lines;
            }
            return new string[] { };
        }
        public string getCurrentPath()
        {
            return this.currentPath;
        }

        public void updateToFilePath(string path, List<string> lines)
        {
            File.WriteAllLines(path, lines.ToArray());
        }
    }
    
}
