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
    // Product
    internal class Production_ProductConfiguration : EntityTypeConfiguration<Production_Product>
    {
        public Production_ProductConfiguration(string schema = "Production")
        {
            ToTable(schema + ".Product");
            HasKey(x => x.ProductId);

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ProductNumber).HasColumnName("ProductNumber").IsRequired().HasMaxLength(25);
            Property(x => x.MakeFlag).HasColumnName("MakeFlag").IsRequired();
            Property(x => x.FinishedGoodsFlag).HasColumnName("FinishedGoodsFlag").IsRequired();
            Property(x => x.Color).HasColumnName("Color").IsOptional().HasMaxLength(15);
            Property(x => x.SafetyStockLevel).HasColumnName("SafetyStockLevel").IsRequired();
            Property(x => x.ReorderPoint).HasColumnName("ReorderPoint").IsRequired();
            Property(x => x.StandardCost).HasColumnName("StandardCost").IsRequired().HasPrecision(19,4);
            Property(x => x.ListPrice).HasColumnName("ListPrice").IsRequired().HasPrecision(19,4);
            Property(x => x.Size).HasColumnName("Size").IsOptional().HasMaxLength(5);
            Property(x => x.SizeUnitMeasureCode).HasColumnName("SizeUnitMeasureCode").IsOptional().IsFixedLength().HasMaxLength(3);
            Property(x => x.WeightUnitMeasureCode).HasColumnName("WeightUnitMeasureCode").IsOptional().IsFixedLength().HasMaxLength(3);
            Property(x => x.Weight).HasColumnName("Weight").IsOptional().HasPrecision(8,2);
            Property(x => x.DaysToManufacture).HasColumnName("DaysToManufacture").IsRequired();
            Property(x => x.ProductLine).HasColumnName("ProductLine").IsOptional().IsFixedLength().HasMaxLength(2);
            Property(x => x.Class).HasColumnName("Class").IsOptional().IsFixedLength().HasMaxLength(2);
            Property(x => x.Style).HasColumnName("Style").IsOptional().IsFixedLength().HasMaxLength(2);
            Property(x => x.ProductSubcategoryId).HasColumnName("ProductSubcategoryID").IsOptional();
            Property(x => x.ProductModelId).HasColumnName("ProductModelID").IsOptional();
            Property(x => x.SellStartDate).HasColumnName("SellStartDate").IsRequired();
            Property(x => x.SellEndDate).HasColumnName("SellEndDate").IsOptional();
            Property(x => x.DiscontinuedDate).HasColumnName("DiscontinuedDate").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasOptional(a => a.Production_UnitMeasure_SizeUnitMeasureCode).WithMany(b => b.Production_Product_SizeUnitMeasureCode).HasForeignKey(c => c.SizeUnitMeasureCode); // FK_Product_UnitMeasure_SizeUnitMeasureCode
            HasOptional(a => a.Production_UnitMeasure_WeightUnitMeasureCode).WithMany(b => b.Production_Product_WeightUnitMeasureCode).HasForeignKey(c => c.WeightUnitMeasureCode); // FK_Product_UnitMeasure_WeightUnitMeasureCode
            HasOptional(a => a.Production_ProductSubcategory).WithMany(b => b.Production_Product).HasForeignKey(c => c.ProductSubcategoryId); // FK_Product_ProductSubcategory_ProductSubcategoryID
            HasOptional(a => a.Production_ProductModel).WithMany(b => b.Production_Product).HasForeignKey(c => c.ProductModelId); // FK_Product_ProductModel_ProductModelID
        }
    }

}
