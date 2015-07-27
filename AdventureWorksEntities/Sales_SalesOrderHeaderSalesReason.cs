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
    // SalesOrderHeaderSalesReason
    public class Sales_SalesOrderHeaderSalesReason
    {
        public int SalesOrderId { get; set; } // SalesOrderID (Primary key). Primary key. Foreign key to SalesOrderHeader.SalesOrderID.
        public int SalesReasonId { get; set; } // SalesReasonID (Primary key). Primary key. Foreign key to SalesReason.SalesReasonID.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Sales_SalesOrderHeader Sales_SalesOrderHeader { get; set; } // FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderID
        public virtual Sales_SalesReason Sales_SalesReason { get; set; } // FK_SalesOrderHeaderSalesReason_SalesReason_SalesReasonID
        
        public Sales_SalesOrderHeaderSalesReason()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
