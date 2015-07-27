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
    // Location
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.13.0.0")]
    public class Production_Location
    {
        public short LocationId { get; set; } // LocationID (Primary key). Primary key for Location records.
        public string Name { get; set; } // Name. Location description.
        public decimal CostRate { get; set; } // CostRate. Standard hourly cost of the manufacturing location.
        public decimal Availability { get; set; } // Availability. Work capacity (in hours) of the manufacturing location.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Production_ProductInventory> Production_ProductInventory { get; set; } // Many to many mapping
        public virtual ICollection<Production_WorkOrderRouting> Production_WorkOrderRouting { get; set; } // WorkOrderRouting.FK_WorkOrderRouting_Location_LocationID
        
        public Production_Location()
        {
            CostRate = 0.00m;
            Availability = 0.00m;
            ModifiedDate = System.DateTime.Now;
            Production_ProductInventory = new List<Production_ProductInventory>();
            Production_WorkOrderRouting = new List<Production_WorkOrderRouting>();
        }
    }

}
