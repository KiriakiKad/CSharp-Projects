using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDegreeLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new StudentRepo();
            
            var passedStudents = from s in students.Students
                                 where s.Degree >= 50
                                 orderby s.Degree descending
                                 select s.Name;

            Console.WriteLine("Students who passed:");
            foreach (var name in passedStudents)
            {
                Console.WriteLine(name);
            }


        }
    }
}
