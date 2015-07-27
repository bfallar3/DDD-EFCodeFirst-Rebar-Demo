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
    // ProductModelProductDescriptionCulture
    internal class Production_ProductModelProductDescriptionCultureConfiguration : EntityTypeConfiguration<Production_ProductModelProductDescriptionCulture>
    {
        public Production_ProductModelProductDescriptionCultureConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductModelProductDescriptionCulture");
            HasKey(x => new { x.ProductModelId, x.ProductDescriptionId, x.CultureId });

            Property(x => x.ProductModelId).HasColumnName("ProductModelID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductDescriptionId).HasColumnName("ProductDescriptionID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CultureId).HasColumnName("CultureID").IsRequired().IsFixedLength().HasMaxLength(6).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_ProductModel).WithMany(b => b.Production_ProductModelProductDescriptionCulture).HasForeignKey(c => c.ProductModelId); // FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID
            HasRequired(a => a.Production_ProductDescription).WithMany(b => b.Production_ProductModelProductDescriptionCulture).HasForeignKey(c => c.ProductDescriptionId); // FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID
            HasRequired(a => a.Production_Culture).WithMany(b => b.Production_ProductModelProductDescriptionCulture).HasForeignKey(c => c.CultureId); // FK_ProductModelProductDescriptionCulture_Culture_CultureID
        }
    }

}
