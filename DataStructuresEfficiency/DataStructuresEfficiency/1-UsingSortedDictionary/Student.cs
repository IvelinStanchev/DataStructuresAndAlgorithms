using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_UsingSortedDictionary
{
    public class Student : IComparable
    {
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int CompareTo(object obj)
        {
            int result = 0;
            if (obj == null)
            {
                return 1;
            }

            Student otherStudent = obj as Student;

            result = this.FirstName.CompareTo(otherStudent.FirstName);

            if (result != 0)
            {
                return result;
            }

            result = this.LastName.CompareTo(otherStudent.LastName);
            if (result != 0)
            {
                return result;
            }

            return 0;
        }
    }
}
