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
    // Vendor
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.13.0.0")]
    public class Purchasing_Vendor
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key for Vendor records.  Foreign key to BusinessEntity.BusinessEntityID
        public string AccountNumber { get; set; } // AccountNumber. Vendor account (identification) number.
        public string Name { get; set; } // Name. Company name.
        public byte CreditRating { get; set; } // CreditRating. 1 = Superior, 2 = Excellent, 3 = Above average, 4 = Average, 5 = Below average
        public bool PreferredVendorStatus { get; set; } // PreferredVendorStatus. 0 = Do not use if another vendor is available. 1 = Preferred over other vendors supplying the same product.
        public bool ActiveFlag { get; set; } // ActiveFlag. 0 = Vendor no longer used. 1 = Vendor is actively used.
        public string PurchasingWebServiceUrl { get; set; } // PurchasingWebServiceURL. Vendor URL.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Purchasing_ProductVendor> Purchasing_ProductVendor { get; set; } // Many to many mapping
        public virtual ICollection<Purchasing_PurchaseOrderHeader> Purchasing_PurchaseOrderHeader { get; set; } // PurchaseOrderHeader.FK_PurchaseOrderHeader_Vendor_VendorID

        // Foreign keys
        public virtual Person_BusinessEntity Person_BusinessEntity { get; set; } // FK_Vendor_BusinessEntity_BusinessEntityID
        
        public Purchasing_Vendor()
        {
            PreferredVendorStatus = true;
            ActiveFlag = true;
            ModifiedDate = System.DateTime.Now;
            Purchasing_ProductVendor = new List<Purchasing_ProductVendor>();
            Purchasing_PurchaseOrderHeader = new List<Purchasing_PurchaseOrderHeader>();
        }
    }

}
