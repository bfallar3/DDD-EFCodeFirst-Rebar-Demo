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
    // SpecialOfferProduct
    internal class Sales_SpecialOfferProductConfiguration : EntityTypeConfiguration<Sales_SpecialOfferProduct>
    {
        public Sales_SpecialOfferProductConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SpecialOfferProduct");
            HasKey(x => new { x.SpecialOfferId, x.ProductId });

            Property(x => x.SpecialOfferId).HasColumnName("SpecialOfferID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_SpecialOffer).WithMany(b => b.Sales_SpecialOfferProduct).HasForeignKey(c => c.SpecialOfferId); // FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID
            HasRequired(a => a.Production_Product).WithMany(b => b.Sales_SpecialOfferProduct).HasForeignKey(c => c.ProductId); // FK_SpecialOfferProduct_Product_ProductID
        }
    }

}
