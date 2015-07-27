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
    // ProductPhoto
    internal class Production_ProductPhotoConfiguration : EntityTypeConfiguration<Production_ProductPhoto>
    {
        public Production_ProductPhotoConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductPhoto");
            HasKey(x => x.ProductPhotoId);

            Property(x => x.ProductPhotoId).HasColumnName("ProductPhotoID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ThumbNailPhoto).HasColumnName("ThumbNailPhoto").IsOptional();
            Property(x => x.ThumbnailPhotoFileName).HasColumnName("ThumbnailPhotoFileName").IsOptional().HasMaxLength(50);
            Property(x => x.LargePhoto).HasColumnName("LargePhoto").IsOptional();
            Property(x => x.LargePhotoFileName).HasColumnName("LargePhotoFileName").IsOptional().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

}
