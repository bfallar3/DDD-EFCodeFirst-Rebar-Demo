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
    // ProductModelIllustration
    public class Production_ProductModelIllustration
    {
        public int ProductModelId { get; set; } // ProductModelID (Primary key). Primary key. Foreign key to ProductModel.ProductModelID.
        public int IllustrationId { get; set; } // IllustrationID (Primary key). Primary key. Foreign key to Illustration.IllustrationID.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Production_Illustration Production_Illustration { get; set; } // FK_ProductModelIllustration_Illustration_IllustrationID
        public virtual Production_ProductModel Production_ProductModel { get; set; } // FK_ProductModelIllustration_ProductModel_ProductModelID
        
        public Production_ProductModelIllustration()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
