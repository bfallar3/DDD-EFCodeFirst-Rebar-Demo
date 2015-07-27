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
    // vVendorWithContacts
    internal class Purchasing_VVendorWithContactConfiguration : EntityTypeConfiguration<Purchasing_VVendorWithContact>
    {
        public Purchasing_VVendorWithContactConfiguration(string schema = "Purchasing")
        {
            ToTable(schema + ".vVendorWithContacts");
            HasKey(x => new { x.BusinessEntityId, x.Name, x.ContactType, x.FirstName, x.LastName, x.EmailPromotion });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired();
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ContactType).HasColumnName("ContactType").IsRequired().HasMaxLength(50);
            Property(x => x.Title).HasColumnName("Title").IsOptional().HasMaxLength(8);
            Property(x => x.FirstName).HasColumnName("FirstName").IsRequired().HasMaxLength(50);
            Property(x => x.MiddleName).HasColumnName("MiddleName").IsOptional().HasMaxLength(50);
            Property(x => x.LastName).HasColumnName("LastName").IsRequired().HasMaxLength(50);
            Property(x => x.Suffix).HasColumnName("Suffix").IsOptional().HasMaxLength(10);
            Property(x => x.PhoneNumber).HasColumnName("PhoneNumber").IsOptional().HasMaxLength(25);
            Property(x => x.PhoneNumberType).HasColumnName("PhoneNumberType").IsOptional().HasMaxLength(50);
            Property(x => x.EmailAddress).HasColumnName("EmailAddress").IsOptional().HasMaxLength(50);
            Property(x => x.EmailPromotion).HasColumnName("EmailPromotion").IsRequired();
        }
    }

}
