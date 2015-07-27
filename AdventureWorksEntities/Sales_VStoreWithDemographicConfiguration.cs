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
    // vStoreWithDemographics
    internal class Sales_VStoreWithDemographicConfiguration : EntityTypeConfiguration<Sales_VStoreWithDemographic>
    {
        public Sales_VStoreWithDemographicConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".vStoreWithDemographics");
            HasKey(x => new { x.BusinessEntityId, x.Name });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired();
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.AnnualSales).HasColumnName("AnnualSales").IsOptional().HasPrecision(19,4);
            Property(x => x.AnnualRevenue).HasColumnName("AnnualRevenue").IsOptional().HasPrecision(19,4);
            Property(x => x.BankName).HasColumnName("BankName").IsOptional().HasMaxLength(50);
            Property(x => x.BusinessType).HasColumnName("BusinessType").IsOptional().HasMaxLength(5);
            Property(x => x.YearOpened).HasColumnName("YearOpened").IsOptional();
            Property(x => x.Specialty).HasColumnName("Specialty").IsOptional().HasMaxLength(50);
            Property(x => x.SquareFeet).HasColumnName("SquareFeet").IsOptional();
            Property(x => x.Brands).HasColumnName("Brands").IsOptional().HasMaxLength(30);
            Property(x => x.Internet).HasColumnName("Internet").IsOptional().HasMaxLength(30);
            Property(x => x.NumberEmployees).HasColumnName("NumberEmployees").IsOptional();
        }
    }

}
