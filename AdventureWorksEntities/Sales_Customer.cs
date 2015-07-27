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
    // Customer
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.13.0.0")]
    public class Sales_Customer
    {
        public int CustomerId { get; set; } // CustomerID (Primary key). Primary key.
        public int? PersonId { get; set; } // PersonID. Foreign key to Person.BusinessEntityID
        public int? StoreId { get; set; } // StoreID. Foreign key to Store.BusinessEntityID
        public int? TerritoryId { get; set; } // TerritoryID. ID of the territory in which the customer is located. Foreign key to SalesTerritory.SalesTerritoryID.
        public string AccountNumber { get; set; } // AccountNumber. Unique number identifying the customer assigned by the accounting system.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeader { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_Customer_CustomerID

        // Foreign keys
        public virtual Person_Person Person_Person { get; set; } // FK_Customer_Person_PersonID
        public virtual Sales_SalesTerritory Sales_SalesTerritory { get; set; } // FK_Customer_SalesTerritory_TerritoryID
        public virtual Sales_Store Sales_Store { get; set; } // FK_Customer_Store_StoreID
        
        public Sales_Customer()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Sales_SalesOrderHeader = new List<Sales_SalesOrderHeader>();
        }
    }

}
