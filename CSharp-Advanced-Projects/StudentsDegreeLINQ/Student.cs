using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDegreeLINQ
{
    public class Student
    {
        public string Name { get; set; }
        public int Degree { get; set; }

        public Student(string name, int degree)
        {
            Name = name;
            Degree = degree;
        }

    }
}
