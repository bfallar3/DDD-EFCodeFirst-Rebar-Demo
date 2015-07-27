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
    // vProductModelInstructions
    public class Production_VProductModelInstruction
    {
        public int ProductModelId { get; set; } // ProductModelID
        public string Name { get; set; } // Name
        public string Instructions { get; set; } // Instructions
        public int? LocationId { get; set; } // LocationID
        public decimal? SetupHours { get; set; } // SetupHours
        public decimal? MachineHours { get; set; } // MachineHours
        public decimal? LaborHours { get; set; } // LaborHours
        public int? LotSize { get; set; } // LotSize
        public string Step { get; set; } // Step
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate
    }

}
