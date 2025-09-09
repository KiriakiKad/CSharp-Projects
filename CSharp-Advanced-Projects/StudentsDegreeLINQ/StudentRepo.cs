using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDegreeLINQ
{
    public class StudentRepo
    {
        public List<Student> Students { get; set; }

        public StudentRepo()
        {
            Students = new List<Student>
            {
                new Student("Alice", 85),
                new Student("Bob", 92),
                new Student("Charlie", 78),
                new Student("Diana", 88),
                new Student("Ethan", 95),
                new Student("Fiona", 45)
            };
        }


    }
}
