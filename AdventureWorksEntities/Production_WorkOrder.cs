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
    // WorkOrder
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.13.0.0")]
    public class Production_WorkOrder
    {
        public int WorkOrderId { get; set; } // WorkOrderID (Primary key). Primary key for WorkOrder records.
        public int ProductId { get; set; } // ProductID. Product identification number. Foreign key to Product.ProductID.
        public int OrderQty { get; set; } // OrderQty. Product quantity to build.
        public int StockedQty { get; set; } // StockedQty. Quantity built and put in inventory.
        public short ScrappedQty { get; set; } // ScrappedQty. Quantity that failed inspection.
        public DateTime StartDate { get; set; } // StartDate. Work order start date.
        public DateTime? EndDate { get; set; } // EndDate. Work order end date.
        public DateTime DueDate { get; set; } // DueDate. Work order due date.
        public short? ScrapReasonId { get; set; } // ScrapReasonID. Reason for inspection failure.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Production_WorkOrderRouting> Production_WorkOrderRouting { get; set; } // Many to many mapping

        // Foreign keys
        public virtual Production_Product Production_Product { get; set; } // FK_WorkOrder_Product_ProductID
        public virtual Production_ScrapReason Production_ScrapReason { get; set; } // FK_WorkOrder_ScrapReason_ScrapReasonID
        
        public Production_WorkOrder()
        {
            ModifiedDate = System.DateTime.Now;
            Production_WorkOrderRouting = new List<Production_WorkOrderRouting>();
        }
    }

}
