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
    // BillOfMaterials
    internal class Production_BillOfMaterialConfiguration : EntityTypeConfiguration<Production_BillOfMaterial>
    {
        public Production_BillOfMaterialConfiguration(string schema = "Production")
        {
            ToTable(schema + ".BillOfMaterials");
            HasKey(x => x.BillOfMaterialsId);

            Property(x => x.BillOfMaterialsId).HasColumnName("BillOfMaterialsID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductAssemblyId).HasColumnName("ProductAssemblyID").IsOptional();
            Property(x => x.ComponentId).HasColumnName("ComponentID").IsRequired();
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            Property(x => x.UnitMeasureCode).HasColumnName("UnitMeasureCode").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.BomLevel).HasColumnName("BOMLevel").IsRequired();
            Property(x => x.PerAssemblyQty).HasColumnName("PerAssemblyQty").IsRequired().HasPrecision(8,2);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasOptional(a => a.Production_Product_ProductAssemblyId).WithMany(b => b.Production_BillOfMaterial_ProductAssemblyId).HasForeignKey(c => c.ProductAssemblyId); // FK_BillOfMaterials_Product_ProductAssemblyID
            HasRequired(a => a.Production_Product_ComponentId).WithMany(b => b.Production_BillOfMaterial_ComponentId).HasForeignKey(c => c.ComponentId); // FK_BillOfMaterials_Product_ComponentID
            HasRequired(a => a.Production_UnitMeasure).WithMany(b => b.Production_BillOfMaterial).HasForeignKey(c => c.UnitMeasureCode); // FK_BillOfMaterials_UnitMeasure_UnitMeasureCode
        }
    }

}
