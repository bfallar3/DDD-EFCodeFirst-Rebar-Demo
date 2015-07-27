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
    // SalesPerson
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.13.0.0")]
    public class Sales_SalesPerson
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key for SalesPerson records. Foreign key to Employee.BusinessEntityID
        public int? TerritoryId { get; set; } // TerritoryID. Territory currently assigned to. Foreign key to SalesTerritory.SalesTerritoryID.
        public decimal? SalesQuota { get; set; } // SalesQuota. Projected yearly sales.
        public decimal Bonus { get; set; } // Bonus. Bonus due if quota is met.
        public decimal CommissionPct { get; set; } // CommissionPct. Commision percent received per sale.
        public decimal SalesYtd { get; set; } // SalesYTD. Sales total year to date.
        public decimal SalesLastYear { get; set; } // SalesLastYear. Sales total of previous year.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeader { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_SalesPerson_SalesPersonID
        public virtual ICollection<Sales_SalesPersonQuotaHistory> Sales_SalesPersonQuotaHistory { get; set; } // Many to many mapping
        public virtual ICollection<Sales_SalesTerritoryHistory> Sales_SalesTerritoryHistory { get; set; } // Many to many mapping
        public virtual ICollection<Sales_Store> Sales_Store { get; set; } // Store.FK_Store_SalesPerson_SalesPersonID

        // Foreign keys
        public virtual HumanResources_Employee HumanResources_Employee { get; set; } // FK_SalesPerson_Employee_BusinessEntityID
        public virtual Sales_SalesTerritory Sales_SalesTerritory { get; set; } // FK_SalesPerson_SalesTerritory_TerritoryID
        
        public Sales_SalesPerson()
        {
            Bonus = 0.00m;
            CommissionPct = 0.00m;
            SalesYtd = 0.00m;
            SalesLastYear = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Sales_SalesOrderHeader = new List<Sales_SalesOrderHeader>();
            Sales_SalesPersonQuotaHistory = new List<Sales_SalesPersonQuotaHistory>();
            Sales_SalesTerritoryHistory = new List<Sales_SalesTerritoryHistory>();
            Sales_Store = new List<Sales_Store>();
        }
    }

}
