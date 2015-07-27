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
    // ProductListPriceHistory
    public class Production_ProductListPriceHistory
    {
        public int ProductId { get; set; } // ProductID (Primary key). Product identification number. Foreign key to Product.ProductID
        public DateTime StartDate { get; set; } // StartDate (Primary key). List price start date.
        public DateTime? EndDate { get; set; } // EndDate. List price end date
        public decimal ListPrice { get; set; } // ListPrice. Product list price.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Production_Product Production_Product { get; set; } // FK_ProductListPriceHistory_Product_ProductID
        
        public Production_ProductListPriceHistory()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
