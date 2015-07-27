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
    // ProductProductPhoto
    public class Production_ProductProductPhoto
    {
        public int ProductId { get; set; } // ProductID (Primary key). Product identification number. Foreign key to Product.ProductID.
        public int ProductPhotoId { get; set; } // ProductPhotoID (Primary key). Product photo identification number. Foreign key to ProductPhoto.ProductPhotoID.
        public bool Primary { get; set; } // Primary. 0 = Photo is not the principal image. 1 = Photo is the principal image.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Production_Product Production_Product { get; set; } // FK_ProductProductPhoto_Product_ProductID
        public virtual Production_ProductPhoto Production_ProductPhoto { get; set; } // FK_ProductProductPhoto_ProductPhoto_ProductPhotoID
        
        public Production_ProductProductPhoto()
        {
            Primary = false;
            ModifiedDate = System.DateTime.Now;
        }
    }

}
