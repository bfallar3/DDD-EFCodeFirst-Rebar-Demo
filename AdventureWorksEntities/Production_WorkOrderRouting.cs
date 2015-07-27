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
    // WorkOrderRouting
    public class Production_WorkOrderRouting
    {
        public int WorkOrderId { get; set; } // WorkOrderID (Primary key). Primary key. Foreign key to WorkOrder.WorkOrderID.
        public int ProductId { get; set; } // ProductID (Primary key). Primary key. Foreign key to Product.ProductID.
        public short OperationSequence { get; set; } // OperationSequence (Primary key). Primary key. Indicates the manufacturing process sequence.
        public short LocationId { get; set; } // LocationID. Manufacturing location where the part is processed. Foreign key to Location.LocationID.
        public DateTime ScheduledStartDate { get; set; } // ScheduledStartDate. Planned manufacturing start date.
        public DateTime ScheduledEndDate { get; set; } // ScheduledEndDate. Planned manufacturing end date.
        public DateTime? ActualStartDate { get; set; } // ActualStartDate. Actual start date.
        public DateTime? ActualEndDate { get; set; } // ActualEndDate. Actual end date.
        public decimal? ActualResourceHrs { get; set; } // ActualResourceHrs. Number of manufacturing hours used.
        public decimal PlannedCost { get; set; } // PlannedCost. Estimated manufacturing cost.
        public decimal? ActualCost { get; set; } // ActualCost. Actual manufacturing cost.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Production_Location Production_Location { get; set; } // FK_WorkOrderRouting_Location_LocationID
        public virtual Production_WorkOrder Production_WorkOrder { get; set; } // FK_WorkOrderRouting_WorkOrder_WorkOrderID
        
        public Production_WorkOrderRouting()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
