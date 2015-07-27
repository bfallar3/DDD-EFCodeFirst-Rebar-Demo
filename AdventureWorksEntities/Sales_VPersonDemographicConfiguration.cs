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
    // vPersonDemographics
    internal class Sales_VPersonDemographicConfiguration : EntityTypeConfiguration<Sales_VPersonDemographic>
    {
        public Sales_VPersonDemographicConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".vPersonDemographics");
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired();
            Property(x => x.TotalPurchaseYtd).HasColumnName("TotalPurchaseYTD").IsOptional().HasPrecision(19,4);
            Property(x => x.DateFirstPurchase).HasColumnName("DateFirstPurchase").IsOptional();
            Property(x => x.BirthDate).HasColumnName("BirthDate").IsOptional();
            Property(x => x.MaritalStatus).HasColumnName("MaritalStatus").IsOptional().HasMaxLength(1);
            Property(x => x.YearlyIncome).HasColumnName("YearlyIncome").IsOptional().HasMaxLength(30);
            Property(x => x.Gender).HasColumnName("Gender").IsOptional().HasMaxLength(1);
            Property(x => x.TotalChildren).HasColumnName("TotalChildren").IsOptional();
            Property(x => x.NumberChildrenAtHome).HasColumnName("NumberChildrenAtHome").IsOptional();
            Property(x => x.Education).HasColumnName("Education").IsOptional().HasMaxLength(30);
            Property(x => x.Occupation).HasColumnName("Occupation").IsOptional().HasMaxLength(30);
            Property(x => x.HomeOwnerFlag).HasColumnName("HomeOwnerFlag").IsOptional();
            Property(x => x.NumberCarsOwned).HasColumnName("NumberCarsOwned").IsOptional();
        }
    }

}
