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
    // vProductModelCatalogDescription
    public class Production_VProductModelCatalogDescription
    {
        public int ProductModelId { get; set; } // ProductModelID
        public string Name { get; set; } // Name
        public string Summary { get; set; } // Summary
        public string Manufacturer { get; set; } // Manufacturer
        public string Copyright { get; set; } // Copyright
        public string ProductUrl { get; set; } // ProductURL
        public string WarrantyPeriod { get; set; } // WarrantyPeriod
        public string WarrantyDescription { get; set; } // WarrantyDescription
        public string NoOfYears { get; set; } // NoOfYears
        public string MaintenanceDescription { get; set; } // MaintenanceDescription
        public string Wheel { get; set; } // Wheel
        public string Saddle { get; set; } // Saddle
        public string Pedal { get; set; } // Pedal
        public string BikeFrame { get; set; } // BikeFrame
        public string Crankset { get; set; } // Crankset
        public string PictureAngle { get; set; } // PictureAngle
        public string PictureSize { get; set; } // PictureSize
        public string ProductPhotoId { get; set; } // ProductPhotoID
        public string Material { get; set; } // Material
        public string Color { get; set; } // Color
        public string ProductLine { get; set; } // ProductLine
        public string Style { get; set; } // Style
        public string RiderExperience { get; set; } // RiderExperience
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate
    }

}
