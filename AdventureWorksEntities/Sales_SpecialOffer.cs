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
    // SpecialOffer
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.13.0.0")]
    public class Sales_SpecialOffer
    {
        public int SpecialOfferId { get; set; } // SpecialOfferID (Primary key). Primary key for SpecialOffer records.
        public string Description { get; set; } // Description. Discount description.
        public decimal DiscountPct { get; set; } // DiscountPct. Discount precentage.
        public string Type { get; set; } // Type. Discount type category.
        public string Category { get; set; } // Category. Group the discount applies to such as Reseller or Customer.
        public DateTime StartDate { get; set; } // StartDate. Discount start date.
        public DateTime EndDate { get; set; } // EndDate. Discount end date.
        public int MinQty { get; set; } // MinQty. Minimum discount percent allowed.
        public int? MaxQty { get; set; } // MaxQty. Maximum discount percent allowed.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Sales_SpecialOfferProduct> Sales_SpecialOfferProduct { get; set; } // Many to many mapping
        
        public Sales_SpecialOffer()
        {
            DiscountPct = 0.00m;
            MinQty = 0;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Sales_SpecialOfferProduct = new List<Sales_SpecialOfferProduct>();
        }
    }

}
