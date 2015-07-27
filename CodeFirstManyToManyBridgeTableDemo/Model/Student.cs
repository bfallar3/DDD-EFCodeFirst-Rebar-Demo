using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstManyToManyBridgeTableDemo.Model
{
    public class Student
    {
        public Student ()
        {
            StudentCourses = new HashSet<StudentCourses>();
        }
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public ICollection<StudentCourses> StudentCourses { get; set; }
    }
}
