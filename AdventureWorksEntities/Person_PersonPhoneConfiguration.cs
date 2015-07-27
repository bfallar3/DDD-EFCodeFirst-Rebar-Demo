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
    // PersonPhone
    internal class Person_PersonPhoneConfiguration : EntityTypeConfiguration<Person_PersonPhone>
    {
        public Person_PersonPhoneConfiguration(string schema = "Person")
        {
            ToTable(schema + ".PersonPhone");
            HasKey(x => new { x.BusinessEntityId, x.PhoneNumber, x.PhoneNumberTypeId });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PhoneNumber).HasColumnName("PhoneNumber").IsRequired().HasMaxLength(25).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PhoneNumberTypeId).HasColumnName("PhoneNumberTypeID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Person_Person).WithMany(b => b.Person_PersonPhone).HasForeignKey(c => c.BusinessEntityId); // FK_PersonPhone_Person_BusinessEntityID
            HasRequired(a => a.Person_PhoneNumberType).WithMany(b => b.Person_PersonPhone).HasForeignKey(c => c.PhoneNumberTypeId); // FK_PersonPhone_PhoneNumberType_PhoneNumberTypeID
        }
    }

}
