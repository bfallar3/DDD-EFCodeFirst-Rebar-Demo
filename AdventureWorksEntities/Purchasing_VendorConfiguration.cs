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
    // Vendor
    internal class Purchasing_VendorConfiguration : EntityTypeConfiguration<Purchasing_Vendor>
    {
        public Purchasing_VendorConfiguration(string schema = "Purchasing")
        {
            ToTable(schema + ".Vendor");
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AccountNumber).HasColumnName("AccountNumber").IsRequired().HasMaxLength(15);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.CreditRating).HasColumnName("CreditRating").IsRequired();
            Property(x => x.PreferredVendorStatus).HasColumnName("PreferredVendorStatus").IsRequired();
            Property(x => x.ActiveFlag).HasColumnName("ActiveFlag").IsRequired();
            Property(x => x.PurchasingWebServiceUrl).HasColumnName("PurchasingWebServiceURL").IsOptional().HasMaxLength(1024);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Person_BusinessEntity).WithOptional(b => b.Purchasing_Vendor); // FK_Vendor_BusinessEntity_BusinessEntityID
        }
    }

}
