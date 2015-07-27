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
    // EmployeePayHistory
    public class HumanResources_EmployeePayHistory
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Employee identification number. Foreign key to Employee.BusinessEntityID.
        public DateTime RateChangeDate { get; set; } // RateChangeDate (Primary key). Date the change in pay is effective
        public decimal Rate { get; set; } // Rate. Salary hourly rate.
        public byte PayFrequency { get; set; } // PayFrequency. 1 = Salary received monthly, 2 = Salary received biweekly
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual HumanResources_Employee HumanResources_Employee { get; set; } // FK_EmployeePayHistory_Employee_BusinessEntityID
        
        public HumanResources_EmployeePayHistory()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
