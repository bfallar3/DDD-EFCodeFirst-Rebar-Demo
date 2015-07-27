using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstManyToManyDemo.Model
{
    public class Course
    {
        public Course ()
        {
            Students = new HashSet<Student>();
        }
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
