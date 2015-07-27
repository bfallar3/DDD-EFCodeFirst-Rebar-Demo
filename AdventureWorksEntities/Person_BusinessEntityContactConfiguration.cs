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
    // BusinessEntityContact
    internal class Person_BusinessEntityContactConfiguration : EntityTypeConfiguration<Person_BusinessEntityContact>
    {
        public Person_BusinessEntityContactConfiguration(string schema = "Person")
        {
            ToTable(schema + ".BusinessEntityContact");
            HasKey(x => new { x.BusinessEntityId, x.PersonId, x.ContactTypeId });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PersonId).HasColumnName("PersonID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ContactTypeId).HasColumnName("ContactTypeID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Person_BusinessEntity).WithMany(b => b.Person_BusinessEntityContact).HasForeignKey(c => c.BusinessEntityId); // FK_BusinessEntityContact_BusinessEntity_BusinessEntityID
            HasRequired(a => a.Person_Person).WithMany(b => b.Person_BusinessEntityContact).HasForeignKey(c => c.PersonId); // FK_BusinessEntityContact_Person_PersonID
            HasRequired(a => a.Person_ContactType).WithMany(b => b.Person_BusinessEntityContact).HasForeignKey(c => c.ContactTypeId); // FK_BusinessEntityContact_ContactType_ContactTypeID
        }
    }

}
