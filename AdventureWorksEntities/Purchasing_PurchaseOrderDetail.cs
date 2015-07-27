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
    // PurchaseOrderDetail
    public class Purchasing_PurchaseOrderDetail
    {
        public int PurchaseOrderId { get; set; } // PurchaseOrderID (Primary key). Primary key. Foreign key to PurchaseOrderHeader.PurchaseOrderID.
        public int PurchaseOrderDetailId { get; set; } // PurchaseOrderDetailID (Primary key). Primary key. One line number per purchased product.
        public DateTime DueDate { get; set; } // DueDate. Date the product is expected to be received.
        public short OrderQty { get; set; } // OrderQty. Quantity ordered.
        public int ProductId { get; set; } // ProductID. Product identification number. Foreign key to Product.ProductID.
        public decimal UnitPrice { get; set; } // UnitPrice. Vendor's selling price of a single product.
        public decimal LineTotal { get; set; } // LineTotal. Per product subtotal. Computed as OrderQty * UnitPrice.
        public decimal ReceivedQty { get; set; } // ReceivedQty. Quantity actually received from the vendor.
        public decimal RejectedQty { get; set; } // RejectedQty. Quantity rejected during inspection.
        public decimal StockedQty { get; set; } // StockedQty. Quantity accepted into inventory. Computed as ReceivedQty - RejectedQty.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Production_Product Production_Product { get; set; } // FK_PurchaseOrderDetail_Product_ProductID
        public virtual Purchasing_PurchaseOrderHeader Purchasing_PurchaseOrderHeader { get; set; } // FK_PurchaseOrderDetail_PurchaseOrderHeader_PurchaseOrderID
        
        public Purchasing_PurchaseOrderDetail()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
