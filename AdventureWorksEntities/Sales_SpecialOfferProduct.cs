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
    // SpecialOfferProduct
    public class Sales_SpecialOfferProduct
    {
        public int SpecialOfferId { get; set; } // SpecialOfferID (Primary key). Primary key for SpecialOfferProduct records.
        public int ProductId { get; set; } // ProductID (Primary key). Product identification number. Foreign key to Product.ProductID.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Production_Product Production_Product { get; set; } // FK_SpecialOfferProduct_Product_ProductID
        public virtual Sales_SpecialOffer Sales_SpecialOffer { get; set; } // FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID
        
        public Sales_SpecialOfferProduct()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

}
