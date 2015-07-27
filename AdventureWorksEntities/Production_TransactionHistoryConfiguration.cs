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
    // TransactionHistory
    internal class Production_TransactionHistoryConfiguration : EntityTypeConfiguration<Production_TransactionHistory>
    {
        public Production_TransactionHistoryConfiguration(string schema = "Production")
        {
            ToTable(schema + ".TransactionHistory");
            HasKey(x => x.TransactionId);

            Property(x => x.TransactionId).HasColumnName("TransactionID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.ReferenceOrderId).HasColumnName("ReferenceOrderID").IsRequired();
            Property(x => x.ReferenceOrderLineId).HasColumnName("ReferenceOrderLineID").IsRequired();
            Property(x => x.TransactionDate).HasColumnName("TransactionDate").IsRequired();
            Property(x => x.TransactionType).HasColumnName("TransactionType").IsRequired().IsFixedLength().HasMaxLength(1);
            Property(x => x.Quantity).HasColumnName("Quantity").IsRequired();
            Property(x => x.ActualCost).HasColumnName("ActualCost").IsRequired().HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_TransactionHistory).HasForeignKey(c => c.ProductId); // FK_TransactionHistory_Product_ProductID
        }
    }

}
