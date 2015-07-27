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
    // ProductModelProductDescriptionCulture
    public class Production_ProductModelProductDescriptionCulture
    {
        public int ProductModelId { get; set; } // ProductModelID (Primary key). Primary key. Foreign key to ProductModel.ProductModelID.
        public int ProductDescriptionId { get; set; } // ProductDescriptionID (Primary key). Primary key. Foreign key to ProductDescription.ProductDescriptionID.
        public string CultureId { get; set; } // CultureID (Primary key). Culture identification number. Foreign key to Culture.CultureID.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Production_Culture Production_Culture { get; set; } // FK_ProductModelProductDescriptionCulture_Culture_CultureID
        public virtual Production_ProductDescription Production_ProductDescription { get; set; } // FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID
        public virtual Production_ProductModel Production_ProductModel { get; set; } // FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID
        
        public Production_ProductModelProductDescriptionCulture()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
