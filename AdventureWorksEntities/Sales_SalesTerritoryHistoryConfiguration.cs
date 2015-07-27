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
    // SalesTerritoryHistory
    internal class Sales_SalesTerritoryHistoryConfiguration : EntityTypeConfiguration<Sales_SalesTerritoryHistory>
    {
        public Sales_SalesTerritoryHistoryConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesTerritoryHistory");
            HasKey(x => new { x.BusinessEntityId, x.TerritoryId, x.StartDate });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_SalesPerson).WithMany(b => b.Sales_SalesTerritoryHistory).HasForeignKey(c => c.BusinessEntityId); // FK_SalesTerritoryHistory_SalesPerson_BusinessEntityID
            HasRequired(a => a.Sales_SalesTerritory).WithMany(b => b.Sales_SalesTerritoryHistory).HasForeignKey(c => c.TerritoryId); // FK_SalesTerritoryHistory_SalesTerritory_TerritoryID
        }
    }

}
