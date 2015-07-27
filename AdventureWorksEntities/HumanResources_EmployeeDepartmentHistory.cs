// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity.ModelConfiguration;
using System.Threading;
using System.Threading.Tasks;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace AdventureWorksEntities
{
    // EmployeeDepartmentHistory
    public class HumanResources_EmployeeDepartmentHistory
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Employee identification number. Foreign key to Employee.BusinessEntityID.
        public short DepartmentId { get; set; } // DepartmentID (Primary key). Department in which the employee worked including currently. Foreign key to Department.DepartmentID.
        public byte ShiftId { get; set; } // ShiftID (Primary key). Identifies which 8-hour shift the employee works. Foreign key to Shift.Shift.ID.
        public DateTime StartDate { get; set; } // StartDate (Primary key). Date the employee started work in the department.
        public DateTime? EndDate { get; set; } // EndDate. Date the employee left the department. NULL = Current department.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual HumanResources_Department HumanResources_Department { get; set; } // FK_EmployeeDepartmentHistory_Department_DepartmentID
        public virtual HumanResources_Employee HumanResources_Employee { get; set; } // FK_EmployeeDepartmentHistory_Employee_BusinessEntityID
        public virtual HumanResources_Shift HumanResources_Shift { get; set; } // FK_EmployeeDepartmentHistory_Shift_ShiftID
        
        public HumanResources_EmployeeDepartmentHistory()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
