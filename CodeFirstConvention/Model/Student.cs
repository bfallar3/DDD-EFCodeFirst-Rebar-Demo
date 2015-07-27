using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConvention.Model
{
    public class Student
    {
        public int StudentNumber { get; set; }
        public string StudentName { get; set; }
        public Nullable<DateTime> EnrolledOn { get; set; }
    }
}
