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
    // PurchaseOrderHeader
    internal class Purchasing_PurchaseOrderHeaderConfiguration : EntityTypeConfiguration<Purchasing_PurchaseOrderHeader>
    {
        public Purchasing_PurchaseOrderHeaderConfiguration(string schema = "Purchasing")
        {
            ToTable(schema + ".PurchaseOrderHeader");
            HasKey(x => x.PurchaseOrderId);

            Property(x => x.PurchaseOrderId).HasColumnName("PurchaseOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.RevisionNumber).HasColumnName("RevisionNumber").IsRequired();
            Property(x => x.Status).HasColumnName("Status").IsRequired();
            Property(x => x.EmployeeId).HasColumnName("EmployeeID").IsRequired();
            Property(x => x.VendorId).HasColumnName("VendorID").IsRequired();
            Property(x => x.ShipMethodId).HasColumnName("ShipMethodID").IsRequired();
            Property(x => x.OrderDate).HasColumnName("OrderDate").IsRequired();
            Property(x => x.ShipDate).HasColumnName("ShipDate").IsOptional();
            Property(x => x.SubTotal).HasColumnName("SubTotal").IsRequired().HasPrecision(19,4);
            Property(x => x.TaxAmt).HasColumnName("TaxAmt").IsRequired().HasPrecision(19,4);
            Property(x => x.Freight).HasColumnName("Freight").IsRequired().HasPrecision(19,4);
            Property(x => x.TotalDue).HasColumnName("TotalDue").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.HumanResources_Employee).WithMany(b => b.Purchasing_PurchaseOrderHeader).HasForeignKey(c => c.EmployeeId); // FK_PurchaseOrderHeader_Employee_EmployeeID
            HasRequired(a => a.Purchasing_Vendor).WithMany(b => b.Purchasing_PurchaseOrderHeader).HasForeignKey(c => c.VendorId); // FK_PurchaseOrderHeader_Vendor_VendorID
            HasRequired(a => a.Purchasing_ShipMethod).WithMany(b => b.Purchasing_PurchaseOrderHeader).HasForeignKey(c => c.ShipMethodId); // FK_PurchaseOrderHeader_ShipMethod_ShipMethodID
        }
    }

}
