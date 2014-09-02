using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _1_UsingSortedDictionary
{
    class UsingSortedDictionary
    {
        private const string PATH = "../../students.txt";

        static void Main()
        {
            SortedDictionary<string, OrderedBag<Student>> coursesWithStudents = new SortedDictionary<string, OrderedBag<Student>>();

            foreach (var currentLine in File.ReadLines(PATH))
            {
                string[] currentLineContent = currentLine.Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var student = new Student(currentLineContent[0], currentLineContent[1]);
                string currentCourseName = currentLineContent[2];

                if (!coursesWithStudents.ContainsKey(currentCourseName))
                {
                    coursesWithStudents.Add(currentCourseName, new OrderedBag<Student>() { student });
                }
                else
                {
                    coursesWithStudents[currentCourseName].Add(student);
                }
            }

            foreach (var courseWithStudents in coursesWithStudents)
            {
                Console.Write(courseWithStudents.Key + ": ");
                for (int i = 0, len = courseWithStudents.Value.Count; i < len; i++)
                {
                    string fullName = courseWithStudents.Value[i].FirstName + " " + courseWithStudents.Value[i].LastName;

                    Console.Write(fullName);
                    if (i != len - 1)
                    {
                        Console.Write(", ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
