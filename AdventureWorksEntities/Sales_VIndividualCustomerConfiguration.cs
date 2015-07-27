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
    // vIndividualCustomer
    internal class Sales_VIndividualCustomerConfiguration : EntityTypeConfiguration<Sales_VIndividualCustomer>
    {
        public Sales_VIndividualCustomerConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".vIndividualCustomer");
            HasKey(x => new { x.BusinessEntityId, x.FirstName, x.LastName, x.EmailPromotion, x.AddressType, x.AddressLine1, x.City, x.StateProvinceName, x.PostalCode, x.CountryRegionName });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired();
            Property(x => x.Title).HasColumnName("Title").IsOptional().HasMaxLength(8);
            Property(x => x.FirstName).HasColumnName("FirstName").IsRequired().HasMaxLength(50);
            Property(x => x.MiddleName).HasColumnName("MiddleName").IsOptional().HasMaxLength(50);
            Property(x => x.LastName).HasColumnName("LastName").IsRequired().HasMaxLength(50);
            Property(x => x.Suffix).HasColumnName("Suffix").IsOptional().HasMaxLength(10);
            Property(x => x.PhoneNumber).HasColumnName("PhoneNumber").IsOptional().HasMaxLength(25);
            Property(x => x.PhoneNumberType).HasColumnName("PhoneNumberType").IsOptional().HasMaxLength(50);
            Property(x => x.EmailAddress).HasColumnName("EmailAddress").IsOptional().HasMaxLength(50);
            Property(x => x.EmailPromotion).HasColumnName("EmailPromotion").IsRequired();
            Property(x => x.AddressType).HasColumnName("AddressType").IsRequired().HasMaxLength(50);
            Property(x => x.AddressLine1).HasColumnName("AddressLine1").IsRequired().HasMaxLength(60);
            Property(x => x.AddressLine2).HasColumnName("AddressLine2").IsOptional().HasMaxLength(60);
            Property(x => x.City).HasColumnName("City").IsRequired().HasMaxLength(30);
            Property(x => x.StateProvinceName).HasColumnName("StateProvinceName").IsRequired().HasMaxLength(50);
            Property(x => x.PostalCode).HasColumnName("PostalCode").IsRequired().HasMaxLength(15);
            Property(x => x.CountryRegionName).HasColumnName("CountryRegionName").IsRequired().HasMaxLength(50);
            Property(x => x.Demographics).HasColumnName("Demographics").IsOptional();
        }
    }

}
