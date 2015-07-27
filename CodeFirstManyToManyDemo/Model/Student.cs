using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstManyToManyDemo.Model
{
    public class Student
    {
        public Student ()
        {
            Courses = new HashSet<Course>();
        }
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
