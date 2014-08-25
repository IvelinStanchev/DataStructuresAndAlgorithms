using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_TraverseADirectory
{
    class TraverseADirectory
    {
        private static List<string> files = new List<string>();

        static void Main(string[] args)
        {
            string rootPath = @"C:\Program Files (x86)";
            string fileExtension = "*.exe";
            Console.WriteLine("The files are being traversed");
            TraverseDirectory(rootPath, fileExtension);

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }

        private static void TraverseDirectory(string currentPath, string fileExtension)
        {
            string[] currentDirFiles = Directory.GetFiles(currentPath, fileExtension);
            files.AddRange(currentDirFiles);

            string[] curretDirDirectories = Directory.GetDirectories(currentPath);
            foreach (var dir in curretDirDirectories)
            {
                TraverseDirectory(dir, fileExtension);
            }
        }
    }
}
