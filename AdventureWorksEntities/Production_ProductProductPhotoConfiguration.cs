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
    // ProductProductPhoto
    internal class Production_ProductProductPhotoConfiguration : EntityTypeConfiguration<Production_ProductProductPhoto>
    {
        public Production_ProductProductPhotoConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductProductPhoto");
            HasKey(x => new { x.ProductId, x.ProductPhotoId });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductPhotoId).HasColumnName("ProductPhotoID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Primary).HasColumnName("Primary").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_ProductProductPhoto).HasForeignKey(c => c.ProductId); // FK_ProductProductPhoto_Product_ProductID
            HasRequired(a => a.Production_ProductPhoto).WithMany(b => b.Production_ProductProductPhoto).HasForeignKey(c => c.ProductPhotoId); // FK_ProductProductPhoto_ProductPhoto_ProductPhotoID
        }
    }

}
