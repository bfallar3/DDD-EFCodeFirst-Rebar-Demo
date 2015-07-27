using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstManyToManyBridgeTableDemo.Model
{
    public class Course
    {
        public Course ()
        {
            StudentCourses = new HashSet<StudentCourses>();
        }
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public ICollection<StudentCourses> StudentCourses { get; set; }
    }
}
