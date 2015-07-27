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
    // TransactionHistory
    public class Production_TransactionHistory
    {
        public int TransactionId { get; set; } // TransactionID (Primary key). Primary key for TransactionHistory records.
        public int ProductId { get; set; } // ProductID. Product identification number. Foreign key to Product.ProductID.
        public int ReferenceOrderId { get; set; } // ReferenceOrderID. Purchase order, sales order, or work order identification number.
        public int ReferenceOrderLineId { get; set; } // ReferenceOrderLineID. Line number associated with the purchase order, sales order, or work order.
        public DateTime TransactionDate { get; set; } // TransactionDate. Date and time of the transaction.
        public string TransactionType { get; set; } // TransactionType. W = WorkOrder, S = SalesOrder, P = PurchaseOrder
        public int Quantity { get; set; } // Quantity. Product quantity.
        public decimal ActualCost { get; set; } // ActualCost. Product cost.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Production_Product Production_Product { get; set; } // FK_TransactionHistory_Product_ProductID
        
        public Production_TransactionHistory()
        {
            ReferenceOrderLineId = 0;
            TransactionDate = System.DateTime.Now;
            ModifiedDate = System.DateTime.Now;
        }
    }

}
