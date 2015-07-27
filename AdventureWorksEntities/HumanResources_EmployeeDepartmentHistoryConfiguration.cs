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
    internal class HumanResources_EmployeeDepartmentHistoryConfiguration : EntityTypeConfiguration<HumanResources_EmployeeDepartmentHistory>
    {
        public HumanResources_EmployeeDepartmentHistoryConfiguration(string schema = "HumanResources")
        {
            ToTable(schema + ".EmployeeDepartmentHistory");
            HasKey(x => new { x.BusinessEntityId, x.DepartmentId, x.ShiftId, x.StartDate });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.DepartmentId).HasColumnName("DepartmentID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ShiftId).HasColumnName("ShiftID").IsRequired();
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.HumanResources_Employee).WithMany(b => b.HumanResources_EmployeeDepartmentHistory).HasForeignKey(c => c.BusinessEntityId); // FK_EmployeeDepartmentHistory_Employee_BusinessEntityID
            HasRequired(a => a.HumanResources_Department).WithMany(b => b.HumanResources_EmployeeDepartmentHistory).HasForeignKey(c => c.DepartmentId); // FK_EmployeeDepartmentHistory_Department_DepartmentID
            HasRequired(a => a.HumanResources_Shift).WithMany(b => b.HumanResources_EmployeeDepartmentHistory).HasForeignKey(c => c.ShiftId); // FK_EmployeeDepartmentHistory_Shift_ShiftID
        }
    }

}
