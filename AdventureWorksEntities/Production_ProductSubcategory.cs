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
    // ProductSubcategory
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.13.0.0")]
    public class Production_ProductSubcategory
    {
        public int ProductSubcategoryId { get; set; } // ProductSubcategoryID (Primary key). Primary key for ProductSubcategory records.
        public int ProductCategoryId { get; set; } // ProductCategoryID. Product category identification number. Foreign key to ProductCategory.ProductCategoryID.
        public string Name { get; set; } // Name. Subcategory description.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Production_Product> Production_Product { get; set; } // Product.FK_Product_ProductSubcategory_ProductSubcategoryID

        // Foreign keys
        public virtual Production_ProductCategory Production_ProductCategory { get; set; } // FK_ProductSubcategory_ProductCategory_ProductCategoryID
        
        public Production_ProductSubcategory()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Production_Product = new List<Production_Product>();
        }
    }

}
