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
    // UnitMeasure
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.13.0.0")]
    public class Production_UnitMeasure
    {
        public string UnitMeasureCode { get; set; } // UnitMeasureCode (Primary key). Primary key.
        public string Name { get; set; } // Name. Unit of measure description.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Production_BillOfMaterial> Production_BillOfMaterial { get; set; } // BillOfMaterials.FK_BillOfMaterials_UnitMeasure_UnitMeasureCode
        public virtual ICollection<Production_Product> Production_Product_SizeUnitMeasureCode { get; set; } // Product.FK_Product_UnitMeasure_SizeUnitMeasureCode
        public virtual ICollection<Production_Product> Production_Product_WeightUnitMeasureCode { get; set; } // Product.FK_Product_UnitMeasure_WeightUnitMeasureCode
        public virtual ICollection<Purchasing_ProductVendor> Purchasing_ProductVendor { get; set; } // ProductVendor.FK_ProductVendor_UnitMeasure_UnitMeasureCode
        
        public Production_UnitMeasure()
        {
            ModifiedDate = System.DateTime.Now;
            Production_BillOfMaterial = new List<Production_BillOfMaterial>();
            Production_Product_SizeUnitMeasureCode = new List<Production_Product>();
            Production_Product_WeightUnitMeasureCode = new List<Production_Product>();
            Purchasing_ProductVendor = new List<Purchasing_ProductVendor>();
        }
    }

}
