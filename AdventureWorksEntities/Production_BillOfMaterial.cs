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
    // BillOfMaterials
    public class Production_BillOfMaterial
    {
        public int BillOfMaterialsId { get; set; } // BillOfMaterialsID (Primary key). Primary key for BillOfMaterials records.
        public int? ProductAssemblyId { get; set; } // ProductAssemblyID. Parent product identification number. Foreign key to Product.ProductID.
        public int ComponentId { get; set; } // ComponentID. Component identification number. Foreign key to Product.ProductID.
        public DateTime StartDate { get; set; } // StartDate. Date the component started being used in the assembly item.
        public DateTime? EndDate { get; set; } // EndDate. Date the component stopped being used in the assembly item.
        public string UnitMeasureCode { get; set; } // UnitMeasureCode. Standard code identifying the unit of measure for the quantity.
        public short BomLevel { get; set; } // BOMLevel. Indicates the depth the component is from its parent (AssemblyID).
        public decimal PerAssemblyQty { get; set; } // PerAssemblyQty. Quantity of the component needed to create the assembly.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Production_Product Production_Product_ComponentId { get; set; } // FK_BillOfMaterials_Product_ComponentID
        public virtual Production_Product Production_Product_ProductAssemblyId { get; set; } // FK_BillOfMaterials_Product_ProductAssemblyID
        public virtual Production_UnitMeasure Production_UnitMeasure { get; set; } // FK_BillOfMaterials_UnitMeasure_UnitMeasureCode
        
        public Production_BillOfMaterial()
        {
            StartDate = System.DateTime.Now;
            PerAssemblyQty = 1.00m;
            ModifiedDate = System.DateTime.Now;
        }
    }

}
