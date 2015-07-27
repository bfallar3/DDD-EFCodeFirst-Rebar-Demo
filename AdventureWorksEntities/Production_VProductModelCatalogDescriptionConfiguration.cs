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
    // vProductModelCatalogDescription
    internal class Production_VProductModelCatalogDescriptionConfiguration : EntityTypeConfiguration<Production_VProductModelCatalogDescription>
    {
        public Production_VProductModelCatalogDescriptionConfiguration(string schema = "Production")
        {
            ToTable(schema + ".vProductModelCatalogDescription");
            HasKey(x => new { x.ProductModelId, x.Name, x.Rowguid, x.ModifiedDate });

            Property(x => x.ProductModelId).HasColumnName("ProductModelID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.Summary).HasColumnName("Summary").IsOptional();
            Property(x => x.Manufacturer).HasColumnName("Manufacturer").IsOptional();
            Property(x => x.Copyright).HasColumnName("Copyright").IsOptional().HasMaxLength(30);
            Property(x => x.ProductUrl).HasColumnName("ProductURL").IsOptional().HasMaxLength(256);
            Property(x => x.WarrantyPeriod).HasColumnName("WarrantyPeriod").IsOptional().HasMaxLength(256);
            Property(x => x.WarrantyDescription).HasColumnName("WarrantyDescription").IsOptional().HasMaxLength(256);
            Property(x => x.NoOfYears).HasColumnName("NoOfYears").IsOptional().HasMaxLength(256);
            Property(x => x.MaintenanceDescription).HasColumnName("MaintenanceDescription").IsOptional().HasMaxLength(256);
            Property(x => x.Wheel).HasColumnName("Wheel").IsOptional().HasMaxLength(256);
            Property(x => x.Saddle).HasColumnName("Saddle").IsOptional().HasMaxLength(256);
            Property(x => x.Pedal).HasColumnName("Pedal").IsOptional().HasMaxLength(256);
            Property(x => x.BikeFrame).HasColumnName("BikeFrame").IsOptional();
            Property(x => x.Crankset).HasColumnName("Crankset").IsOptional().HasMaxLength(256);
            Property(x => x.PictureAngle).HasColumnName("PictureAngle").IsOptional().HasMaxLength(256);
            Property(x => x.PictureSize).HasColumnName("PictureSize").IsOptional().HasMaxLength(256);
            Property(x => x.ProductPhotoId).HasColumnName("ProductPhotoID").IsOptional().HasMaxLength(256);
            Property(x => x.Material).HasColumnName("Material").IsOptional().HasMaxLength(256);
            Property(x => x.Color).HasColumnName("Color").IsOptional().HasMaxLength(256);
            Property(x => x.ProductLine).HasColumnName("ProductLine").IsOptional().HasMaxLength(256);
            Property(x => x.Style).HasColumnName("Style").IsOptional().HasMaxLength(256);
            Property(x => x.RiderExperience).HasColumnName("RiderExperience").IsOptional().HasMaxLength(1024);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

}
