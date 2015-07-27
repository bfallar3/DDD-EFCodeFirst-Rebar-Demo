using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses
{
    public class EmployeeAvatar
    {
        [Key]
        public int EmployeeID { get; set; }
        public byte[] Avatar { get; set; }
    }
}
