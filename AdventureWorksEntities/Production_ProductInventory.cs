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
    // ProductInventory
    public class Production_ProductInventory
    {
        public int ProductId { get; set; } // ProductID (Primary key). Product identification number. Foreign key to Product.ProductID.
        public short LocationId { get; set; } // LocationID (Primary key). Inventory location identification number. Foreign key to Location.LocationID.
        public string Shelf { get; set; } // Shelf. Storage compartment within an inventory location.
        public byte Bin { get; set; } // Bin. Storage container on a shelf in an inventory location.
        public short Quantity { get; set; } // Quantity. Quantity of products in the inventory location.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Production_Location Production_Location { get; set; } // FK_ProductInventory_Location_LocationID
        public virtual Production_Product Production_Product { get; set; } // FK_ProductInventory_Product_ProductID
        
        public Production_ProductInventory()
        {
            Quantity = 0;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

}
