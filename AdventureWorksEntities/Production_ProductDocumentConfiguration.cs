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
    // ProductDocument
    internal class Production_ProductDocumentConfiguration : EntityTypeConfiguration<Production_ProductDocument>
    {
        public Production_ProductDocumentConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductDocument");
            HasKey(x => new { x.ProductId, x.DocumentNode });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.DocumentNode).HasColumnName("DocumentNode").IsRequired().HasMaxLength(892).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_ProductDocument).HasForeignKey(c => c.ProductId); // FK_ProductDocument_Product_ProductID
            HasRequired(a => a.Production_Document).WithMany(b => b.Production_ProductDocument).HasForeignKey(c => c.DocumentNode); // FK_ProductDocument_Document_DocumentNode
        }
    }

}
