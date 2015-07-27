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
    // SalesTerritory
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.13.0.0")]
    public class Sales_SalesTerritory
    {
        public int TerritoryId { get; set; } // TerritoryID (Primary key). Primary key for SalesTerritory records.
        public string Name { get; set; } // Name. Sales territory description
        public string CountryRegionCode { get; set; } // CountryRegionCode. ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode.
        public string Group { get; set; } // Group. Geographic area to which the sales territory belong.
        public decimal SalesYtd { get; set; } // SalesYTD. Sales in the territory year to date.
        public decimal SalesLastYear { get; set; } // SalesLastYear. Sales in the territory the previous year.
        public decimal CostYtd { get; set; } // CostYTD. Business costs in the territory year to date.
        public decimal CostLastYear { get; set; } // CostLastYear. Business costs in the territory the previous year.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Person_StateProvince> Person_StateProvince { get; set; } // StateProvince.FK_StateProvince_SalesTerritory_TerritoryID
        public virtual ICollection<Sales_Customer> Sales_Customer { get; set; } // Customer.FK_Customer_SalesTerritory_TerritoryID
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeader { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_SalesTerritory_TerritoryID
        public virtual ICollection<Sales_SalesPerson> Sales_SalesPerson { get; set; } // SalesPerson.FK_SalesPerson_SalesTerritory_TerritoryID
        public virtual ICollection<Sales_SalesTerritoryHistory> Sales_SalesTerritoryHistory { get; set; } // Many to many mapping

        // Foreign keys
        public virtual Person_CountryRegion Person_CountryRegion { get; set; } // FK_SalesTerritory_CountryRegion_CountryRegionCode
        
        public Sales_SalesTerritory()
        {
            SalesYtd = 0.00m;
            SalesLastYear = 0.00m;
            CostYtd = 0.00m;
            CostLastYear = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Sales_Customer = new List<Sales_Customer>();
            Sales_SalesOrderHeader = new List<Sales_SalesOrderHeader>();
            Sales_SalesPerson = new List<Sales_SalesPerson>();
            Sales_SalesTerritoryHistory = new List<Sales_SalesTerritoryHistory>();
            Person_StateProvince = new List<Person_StateProvince>();
        }
    }

}
