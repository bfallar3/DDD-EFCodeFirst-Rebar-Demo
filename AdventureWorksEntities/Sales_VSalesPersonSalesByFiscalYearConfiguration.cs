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
    // vSalesPersonSalesByFiscalYears
    internal class Sales_VSalesPersonSalesByFiscalYearConfiguration : EntityTypeConfiguration<Sales_VSalesPersonSalesByFiscalYear>
    {
        public Sales_VSalesPersonSalesByFiscalYearConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".vSalesPersonSalesByFiscalYears");
            HasKey(x => new { x.JobTitle, x.SalesTerritory });

            Property(x => x.SalesPersonId).HasColumnName("SalesPersonID").IsOptional();
            Property(x => x.FullName).HasColumnName("FullName").IsOptional().HasMaxLength(152);
            Property(x => x.JobTitle).HasColumnName("JobTitle").IsRequired().HasMaxLength(50);
            Property(x => x.SalesTerritory).HasColumnName("SalesTerritory").IsRequired().HasMaxLength(50);
            Property(x => x.C2002).HasColumnName("2002").IsOptional().HasPrecision(19,4);
            Property(x => x.C2003).HasColumnName("2003").IsOptional().HasPrecision(19,4);
            Property(x => x.C2004).HasColumnName("2004").IsOptional().HasPrecision(19,4);
        }
    }

}
