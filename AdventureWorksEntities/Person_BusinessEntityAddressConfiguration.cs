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
    // BusinessEntityAddress
    internal class Person_BusinessEntityAddressConfiguration : EntityTypeConfiguration<Person_BusinessEntityAddress>
    {
        public Person_BusinessEntityAddressConfiguration(string schema = "Person")
        {
            ToTable(schema + ".BusinessEntityAddress");
            HasKey(x => new { x.BusinessEntityId, x.AddressId, x.AddressTypeId });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AddressId).HasColumnName("AddressID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AddressTypeId).HasColumnName("AddressTypeID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Person_BusinessEntity).WithMany(b => b.Person_BusinessEntityAddress).HasForeignKey(c => c.BusinessEntityId); // FK_BusinessEntityAddress_BusinessEntity_BusinessEntityID
            HasRequired(a => a.Person_Address).WithMany(b => b.Person_BusinessEntityAddress).HasForeignKey(c => c.AddressId); // FK_BusinessEntityAddress_Address_AddressID
            HasRequired(a => a.Person_AddressType).WithMany(b => b.Person_BusinessEntityAddress).HasForeignKey(c => c.AddressTypeId); // FK_BusinessEntityAddress_AddressType_AddressTypeID
        }
    }

}
