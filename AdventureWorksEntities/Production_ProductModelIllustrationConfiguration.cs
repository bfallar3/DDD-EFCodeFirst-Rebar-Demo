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
    // ProductModelIllustration
    internal class Production_ProductModelIllustrationConfiguration : EntityTypeConfiguration<Production_ProductModelIllustration>
    {
        public Production_ProductModelIllustrationConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductModelIllustration");
            HasKey(x => new { x.ProductModelId, x.IllustrationId });

            Property(x => x.ProductModelId).HasColumnName("ProductModelID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.IllustrationId).HasColumnName("IllustrationID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_ProductModel).WithMany(b => b.Production_ProductModelIllustration).HasForeignKey(c => c.ProductModelId); // FK_ProductModelIllustration_ProductModel_ProductModelID
            HasRequired(a => a.Production_Illustration).WithMany(b => b.Production_ProductModelIllustration).HasForeignKey(c => c.IllustrationId); // FK_ProductModelIllustration_Illustration_IllustrationID
        }
    }

}
