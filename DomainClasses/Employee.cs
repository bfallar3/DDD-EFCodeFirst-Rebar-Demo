using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public double Salary { get; set; }
        public Nullable<int> ManagerID { get; set; }
        public Nullable<int> SupervisorID { get; set; }

        //public Address Address { get; set; }

        // navigation properties
        public Employee Manager { get; set; }        
        public Employee Supervisor { get; set; }
        //public virtual EmployeeAvatar Avatar { get; set; }

    }
}
