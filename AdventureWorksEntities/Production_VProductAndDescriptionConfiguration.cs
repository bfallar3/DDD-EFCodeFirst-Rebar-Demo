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
    // vProductAndDescription
    internal class Production_VProductAndDescriptionConfiguration : EntityTypeConfiguration<Production_VProductAndDescription>
    {
        public Production_VProductAndDescriptionConfiguration(string schema = "Production")
        {
            ToTable(schema + ".vProductAndDescription");
            HasKey(x => new { x.ProductId, x.Name, x.ProductModel, x.CultureId, x.Description });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ProductModel).HasColumnName("ProductModel").IsRequired().HasMaxLength(50);
            Property(x => x.CultureId).HasColumnName("CultureID").IsRequired().IsFixedLength().HasMaxLength(6);
            Property(x => x.Description).HasColumnName("Description").IsRequired().HasMaxLength(400);
        }
    }

}
