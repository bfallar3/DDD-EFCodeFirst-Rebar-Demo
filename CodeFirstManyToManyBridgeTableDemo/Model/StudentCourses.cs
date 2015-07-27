using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstManyToManyBridgeTableDemo.Model
{
    public class StudentCourses
    {        
        public int StudentID { get; set; }
        public int CourseID { get; set; }

        public DateTime EnrolledOn { get; set; }

        // navigations
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
