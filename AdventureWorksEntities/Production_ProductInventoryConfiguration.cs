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
    // ProductInventory
    internal class Production_ProductInventoryConfiguration : EntityTypeConfiguration<Production_ProductInventory>
    {
        public Production_ProductInventoryConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductInventory");
            HasKey(x => new { x.ProductId, x.LocationId });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.LocationId).HasColumnName("LocationID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Shelf).HasColumnName("Shelf").IsRequired().HasMaxLength(10);
            Property(x => x.Bin).HasColumnName("Bin").IsRequired();
            Property(x => x.Quantity).HasColumnName("Quantity").IsRequired();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_ProductInventory).HasForeignKey(c => c.ProductId); // FK_ProductInventory_Product_ProductID
            HasRequired(a => a.Production_Location).WithMany(b => b.Production_ProductInventory).HasForeignKey(c => c.LocationId); // FK_ProductInventory_Location_LocationID
        }
    }

}
