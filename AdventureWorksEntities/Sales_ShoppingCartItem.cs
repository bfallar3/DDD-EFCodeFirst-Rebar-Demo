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
    // ShoppingCartItem
    public class Sales_ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; } // ShoppingCartItemID (Primary key). Primary key for ShoppingCartItem records.
        public string ShoppingCartId { get; set; } // ShoppingCartID. Shopping cart identification number.
        public int Quantity { get; set; } // Quantity. Product quantity ordered.
        public int ProductId { get; set; } // ProductID. Product ordered. Foreign key to Product.ProductID.
        public DateTime DateCreated { get; set; } // DateCreated. Date the time the record was created.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Production_Product Production_Product { get; set; } // FK_ShoppingCartItem_Product_ProductID
        
        public Sales_ShoppingCartItem()
        {
            Quantity = 1;
            DateCreated = System.DateTime.Now;
            ModifiedDate = System.DateTime.Now;
        }
    }

}
