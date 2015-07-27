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
    // ProductReview
    public class Production_ProductReview
    {
        public int ProductReviewId { get; set; } // ProductReviewID (Primary key). Primary key for ProductReview records.
        public int ProductId { get; set; } // ProductID. Product identification number. Foreign key to Product.ProductID.
        public string ReviewerName { get; set; } // ReviewerName. Name of the reviewer.
        public DateTime ReviewDate { get; set; } // ReviewDate. Date review was submitted.
        public string EmailAddress { get; set; } // EmailAddress. Reviewer's e-mail address.
        public int Rating { get; set; } // Rating. Product rating given by the reviewer. Scale is 1 to 5 with 5 as the highest rating.
        public string Comments { get; set; } // Comments. Reviewer's comments
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Production_Product Production_Product { get; set; } // FK_ProductReview_Product_ProductID
        
        public Production_ProductReview()
        {
            ReviewDate = System.DateTime.Now;
            ModifiedDate = System.DateTime.Now;
        }
    }

}
