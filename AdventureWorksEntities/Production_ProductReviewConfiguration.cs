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
    // ProductReview
    internal class Production_ProductReviewConfiguration : EntityTypeConfiguration<Production_ProductReview>
    {
        public Production_ProductReviewConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductReview");
            HasKey(x => x.ProductReviewId);

            Property(x => x.ProductReviewId).HasColumnName("ProductReviewID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.ReviewerName).HasColumnName("ReviewerName").IsRequired().HasMaxLength(50);
            Property(x => x.ReviewDate).HasColumnName("ReviewDate").IsRequired();
            Property(x => x.EmailAddress).HasColumnName("EmailAddress").IsRequired().HasMaxLength(50);
            Property(x => x.Rating).HasColumnName("Rating").IsRequired();
            Property(x => x.Comments).HasColumnName("Comments").IsOptional().HasMaxLength(3850);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_ProductReview).HasForeignKey(c => c.ProductId); // FK_ProductReview_Product_ProductID
        }
    }

}
