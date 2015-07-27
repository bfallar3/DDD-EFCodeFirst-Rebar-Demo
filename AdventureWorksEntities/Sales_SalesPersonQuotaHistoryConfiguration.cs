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
    // SalesPersonQuotaHistory
    internal class Sales_SalesPersonQuotaHistoryConfiguration : EntityTypeConfiguration<Sales_SalesPersonQuotaHistory>
    {
        public Sales_SalesPersonQuotaHistoryConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesPersonQuotaHistory");
            HasKey(x => new { x.BusinessEntityId, x.QuotaDate });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.QuotaDate).HasColumnName("QuotaDate").IsRequired();
            Property(x => x.SalesQuota).HasColumnName("SalesQuota").IsRequired().HasPrecision(19,4);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_SalesPerson).WithMany(b => b.Sales_SalesPersonQuotaHistory).HasForeignKey(c => c.BusinessEntityId); // FK_SalesPersonQuotaHistory_SalesPerson_BusinessEntityID
        }
    }

}
