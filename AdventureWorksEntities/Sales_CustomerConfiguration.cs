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
    // Customer
    internal class Sales_CustomerConfiguration : EntityTypeConfiguration<Sales_Customer>
    {
        public Sales_CustomerConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".Customer");
            HasKey(x => x.CustomerId);

            Property(x => x.CustomerId).HasColumnName("CustomerID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.PersonId).HasColumnName("PersonID").IsOptional();
            Property(x => x.StoreId).HasColumnName("StoreID").IsOptional();
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsOptional();
            Property(x => x.AccountNumber).HasColumnName("AccountNumber").IsRequired().IsUnicode(false).HasMaxLength(10).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasOptional(a => a.Person_Person).WithMany(b => b.Sales_Customer).HasForeignKey(c => c.PersonId); // FK_Customer_Person_PersonID
            HasOptional(a => a.Sales_Store).WithMany(b => b.Sales_Customer).HasForeignKey(c => c.StoreId); // FK_Customer_Store_StoreID
            HasOptional(a => a.Sales_SalesTerritory).WithMany(b => b.Sales_Customer).HasForeignKey(c => c.TerritoryId); // FK_Customer_SalesTerritory_TerritoryID
        }
    }

}
