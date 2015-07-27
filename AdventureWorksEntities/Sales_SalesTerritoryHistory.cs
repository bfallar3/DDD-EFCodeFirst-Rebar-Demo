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
    public class Sales_SalesTerritoryHistory
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key. The sales rep.  Foreign key to SalesPerson.BusinessEntityID.
        public int TerritoryId { get; set; } // TerritoryID (Primary key). Primary key. Territory identification number. Foreign key to SalesTerritory.SalesTerritoryID.
        public DateTime StartDate { get; set; } // StartDate (Primary key). Primary key. Date the sales representive started work in the territory.
        public DateTime? EndDate { get; set; } // EndDate. Date the sales representative left work in the territory.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Sales_SalesPerson Sales_SalesPerson { get; set; } // FK_SalesTerritoryHistory_SalesPerson_BusinessEntityID
        public virtual Sales_SalesTerritory Sales_SalesTerritory { get; set; } // FK_SalesTerritoryHistory_SalesTerritory_TerritoryID
        
        public Sales_SalesTerritoryHistory()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

}
