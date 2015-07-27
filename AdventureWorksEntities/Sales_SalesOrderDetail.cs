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
    // SalesOrderDetail
    public class Sales_SalesOrderDetail
    {
        public int SalesOrderId { get; set; } // SalesOrderID (Primary key). Primary key. Foreign key to SalesOrderHeader.SalesOrderID.
        public int SalesOrderDetailId { get; set; } // SalesOrderDetailID (Primary key). Primary key. One incremental unique number per product sold.
        public string CarrierTrackingNumber { get; set; } // CarrierTrackingNumber. Shipment tracking number supplied by the shipper.
        public short OrderQty { get; set; } // OrderQty. Quantity ordered per product.
        public int ProductId { get; set; } // ProductID. Product sold to customer. Foreign key to Product.ProductID.
        public int SpecialOfferId { get; set; } // SpecialOfferID. Promotional code. Foreign key to SpecialOffer.SpecialOfferID.
        public decimal UnitPrice { get; set; } // UnitPrice. Selling price of a single product.
        public decimal UnitPriceDiscount { get; set; } // UnitPriceDiscount. Discount amount.
        public decimal LineTotal { get; set; } // LineTotal. Per product subtotal. Computed as UnitPrice * (1 - UnitPriceDiscount) * OrderQty.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Sales_SalesOrderHeader Sales_SalesOrderHeader { get; set; } // FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID
        
        public Sales_SalesOrderDetail()
        {
            UnitPriceDiscount = 0.0m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

}
