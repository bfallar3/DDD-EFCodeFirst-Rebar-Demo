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
    // ProductVendor
    internal class Purchasing_ProductVendorConfiguration : EntityTypeConfiguration<Purchasing_ProductVendor>
    {
        public Purchasing_ProductVendorConfiguration(string schema = "Purchasing")
        {
            ToTable(schema + ".ProductVendor");
            HasKey(x => new { x.ProductId, x.BusinessEntityId });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AverageLeadTime).HasColumnName("AverageLeadTime").IsRequired();
            Property(x => x.StandardPrice).HasColumnName("StandardPrice").IsRequired().HasPrecision(19,4);
            Property(x => x.LastReceiptCost).HasColumnName("LastReceiptCost").IsOptional().HasPrecision(19,4);
            Property(x => x.LastReceiptDate).HasColumnName("LastReceiptDate").IsOptional();
            Property(x => x.MinOrderQty).HasColumnName("MinOrderQty").IsRequired();
            Property(x => x.MaxOrderQty).HasColumnName("MaxOrderQty").IsRequired();
            Property(x => x.OnOrderQty).HasColumnName("OnOrderQty").IsOptional();
            Property(x => x.UnitMeasureCode).HasColumnName("UnitMeasureCode").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Purchasing_ProductVendor).HasForeignKey(c => c.ProductId); // FK_ProductVendor_Product_ProductID
            HasRequired(a => a.Purchasing_Vendor).WithMany(b => b.Purchasing_ProductVendor).HasForeignKey(c => c.BusinessEntityId); // FK_ProductVendor_Vendor_BusinessEntityID
            HasRequired(a => a.Production_UnitMeasure).WithMany(b => b.Purchasing_ProductVendor).HasForeignKey(c => c.UnitMeasureCode); // FK_ProductVendor_UnitMeasure_UnitMeasureCode
        }
    }

}
