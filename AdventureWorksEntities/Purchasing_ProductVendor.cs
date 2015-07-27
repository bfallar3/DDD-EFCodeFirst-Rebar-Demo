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
    // ProductVendor
    public class Purchasing_ProductVendor
    {
        public int ProductId { get; set; } // ProductID (Primary key). Primary key. Foreign key to Product.ProductID.
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key. Foreign key to Vendor.BusinessEntityID.
        public int AverageLeadTime { get; set; } // AverageLeadTime. The average span of time (in days) between placing an order with the vendor and receiving the purchased product.
        public decimal StandardPrice { get; set; } // StandardPrice. The vendor's usual selling price.
        public decimal? LastReceiptCost { get; set; } // LastReceiptCost. The selling price when last purchased.
        public DateTime? LastReceiptDate { get; set; } // LastReceiptDate. Date the product was last received by the vendor.
        public int MinOrderQty { get; set; } // MinOrderQty. The maximum quantity that should be ordered.
        public int MaxOrderQty { get; set; } // MaxOrderQty. The minimum quantity that should be ordered.
        public int? OnOrderQty { get; set; } // OnOrderQty. The quantity currently on order.
        public string UnitMeasureCode { get; set; } // UnitMeasureCode. The product's unit of measure.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Production_Product Production_Product { get; set; } // FK_ProductVendor_Product_ProductID
        public virtual Production_UnitMeasure Production_UnitMeasure { get; set; } // FK_ProductVendor_UnitMeasure_UnitMeasureCode
        public virtual Purchasing_Vendor Purchasing_Vendor { get; set; } // FK_ProductVendor_Vendor_BusinessEntityID
        
        public Purchasing_ProductVendor()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
