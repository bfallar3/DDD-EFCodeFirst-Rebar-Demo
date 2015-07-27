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
    // SalesOrderHeaderSalesReason
    internal class Sales_SalesOrderHeaderSalesReasonConfiguration : EntityTypeConfiguration<Sales_SalesOrderHeaderSalesReason>
    {
        public Sales_SalesOrderHeaderSalesReasonConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesOrderHeaderSalesReason");
            HasKey(x => new { x.SalesOrderId, x.SalesReasonId });

            Property(x => x.SalesOrderId).HasColumnName("SalesOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.SalesReasonId).HasColumnName("SalesReasonID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_SalesOrderHeader).WithMany(b => b.Sales_SalesOrderHeaderSalesReason).HasForeignKey(c => c.SalesOrderId); // FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderID
            HasRequired(a => a.Sales_SalesReason).WithMany(b => b.Sales_SalesOrderHeaderSalesReason).HasForeignKey(c => c.SalesReasonId); // FK_SalesOrderHeaderSalesReason_SalesReason_SalesReasonID
        }
    }

}
