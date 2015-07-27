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
    // ProductPhoto
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.13.0.0")]
    public class Production_ProductPhoto
    {
        public int ProductPhotoId { get; set; } // ProductPhotoID (Primary key). Primary key for ProductPhoto records.
        public byte[] ThumbNailPhoto { get; set; } // ThumbNailPhoto. Small image of the product.
        public string ThumbnailPhotoFileName { get; set; } // ThumbnailPhotoFileName. Small image file name.
        public byte[] LargePhoto { get; set; } // LargePhoto. Large image of the product.
        public string LargePhotoFileName { get; set; } // LargePhotoFileName. Large image file name.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Production_ProductProductPhoto> Production_ProductProductPhoto { get; set; } // Many to many mapping
        
        public Production_ProductPhoto()
        {
            ModifiedDate = System.DateTime.Now;
            Production_ProductProductPhoto = new List<Production_ProductProductPhoto>();
        }
    }

}
