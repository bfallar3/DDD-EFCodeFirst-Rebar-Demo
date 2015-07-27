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
    // vAdditionalContactInfo
    internal class Person_VAdditionalContactInfoConfiguration : EntityTypeConfiguration<Person_VAdditionalContactInfo>
    {
        public Person_VAdditionalContactInfoConfiguration(string schema = "Person")
        {
            ToTable(schema + ".vAdditionalContactInfo");
            HasKey(x => new { x.BusinessEntityId, x.FirstName, x.LastName, x.Rowguid, x.ModifiedDate });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired();
            Property(x => x.FirstName).HasColumnName("FirstName").IsRequired().HasMaxLength(50);
            Property(x => x.MiddleName).HasColumnName("MiddleName").IsOptional().HasMaxLength(50);
            Property(x => x.LastName).HasColumnName("LastName").IsRequired().HasMaxLength(50);
            Property(x => x.TelephoneNumber).HasColumnName("TelephoneNumber").IsOptional().HasMaxLength(50);
            Property(x => x.TelephoneSpecialInstructions).HasColumnName("TelephoneSpecialInstructions").IsOptional();
            Property(x => x.Street).HasColumnName("Street").IsOptional().HasMaxLength(50);
            Property(x => x.City).HasColumnName("City").IsOptional().HasMaxLength(50);
            Property(x => x.StateProvince).HasColumnName("StateProvince").IsOptional().HasMaxLength(50);
            Property(x => x.PostalCode).HasColumnName("PostalCode").IsOptional().HasMaxLength(50);
            Property(x => x.CountryRegion).HasColumnName("CountryRegion").IsOptional().HasMaxLength(50);
            Property(x => x.HomeAddressSpecialInstructions).HasColumnName("HomeAddressSpecialInstructions").IsOptional();
            Property(x => x.EMailAddress).HasColumnName("EMailAddress").IsOptional().HasMaxLength(128);
            Property(x => x.EMailSpecialInstructions).HasColumnName("EMailSpecialInstructions").IsOptional();
            Property(x => x.EMailTelephoneNumber).HasColumnName("EMailTelephoneNumber").IsOptional().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

}
