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
    // PurchaseOrderHeader
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.13.0.0")]
    public class Purchasing_PurchaseOrderHeader
    {
        public int PurchaseOrderId { get; set; } // PurchaseOrderID (Primary key). Primary key.
        public byte RevisionNumber { get; set; } // RevisionNumber. Incremental number to track changes to the purchase order over time.
        public byte Status { get; set; } // Status. Order current status. 1 = Pending; 2 = Approved; 3 = Rejected; 4 = Complete
        public int EmployeeId { get; set; } // EmployeeID. Employee who created the purchase order. Foreign key to Employee.BusinessEntityID.
        public int VendorId { get; set; } // VendorID. Vendor with whom the purchase order is placed. Foreign key to Vendor.BusinessEntityID.
        public int ShipMethodId { get; set; } // ShipMethodID. Shipping method. Foreign key to ShipMethod.ShipMethodID.
        public DateTime OrderDate { get; set; } // OrderDate. Purchase order creation date.
        public DateTime? ShipDate { get; set; } // ShipDate. Estimated shipment date from the vendor.
        public decimal SubTotal { get; set; } // SubTotal. Purchase order subtotal. Computed as SUM(PurchaseOrderDetail.LineTotal)for the appropriate PurchaseOrderID.
        public decimal TaxAmt { get; set; } // TaxAmt. Tax amount.
        public decimal Freight { get; set; } // Freight. Shipping cost.
        public decimal TotalDue { get; set; } // TotalDue. Total due to vendor. Computed as Subtotal + TaxAmt + Freight.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Purchasing_PurchaseOrderDetail> Purchasing_PurchaseOrderDetail { get; set; } // Many to many mapping

        // Foreign keys
        public virtual HumanResources_Employee HumanResources_Employee { get; set; } // FK_PurchaseOrderHeader_Employee_EmployeeID
        public virtual Purchasing_ShipMethod Purchasing_ShipMethod { get; set; } // FK_PurchaseOrderHeader_ShipMethod_ShipMethodID
        public virtual Purchasing_Vendor Purchasing_Vendor { get; set; } // FK_PurchaseOrderHeader_Vendor_VendorID
        
        public Purchasing_PurchaseOrderHeader()
        {
            RevisionNumber = 0;
            Status = 1;
            OrderDate = System.DateTime.Now;
            SubTotal = 0.00m;
            TaxAmt = 0.00m;
            Freight = 0.00m;
            ModifiedDate = System.DateTime.Now;
            Purchasing_PurchaseOrderDetail = new List<Purchasing_PurchaseOrderDetail>();
        }
    }

}
