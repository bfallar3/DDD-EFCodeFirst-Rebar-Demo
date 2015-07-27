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
    internal class HumanResources_EmployeePayHistoryConfiguration : EntityTypeConfiguration<HumanResources_EmployeePayHistory>
    {
        public HumanResources_EmployeePayHistoryConfiguration(string schema = "HumanResources")
        {
            ToTable(schema + ".EmployeePayHistory");
            HasKey(x => new { x.BusinessEntityId, x.RateChangeDate });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.RateChangeDate).HasColumnName("RateChangeDate").IsRequired();
            Property(x => x.Rate).HasColumnName("Rate").IsRequired().HasPrecision(19,4);
            Property(x => x.PayFrequency).HasColumnName("PayFrequency").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.HumanResources_Employee).WithMany(b => b.HumanResources_EmployeePayHistory).HasForeignKey(c => c.BusinessEntityId); // FK_EmployeePayHistory_Employee_BusinessEntityID
        }
    }

}
