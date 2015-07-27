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
    // ErrorLog
    public class ErrorLog
    {
        public int ErrorLogId { get; set; } // ErrorLogID (Primary key). Primary key for ErrorLog records.
        public DateTime ErrorTime { get; set; } // ErrorTime. The date and time at which the error occurred.
        public string UserName { get; set; } // UserName. The user who executed the batch in which the error occurred.
        public int ErrorNumber { get; set; } // ErrorNumber. The error number of the error that occurred.
        public int? ErrorSeverity { get; set; } // ErrorSeverity. The severity of the error that occurred.
        public int? ErrorState { get; set; } // ErrorState. The state number of the error that occurred.
        public string ErrorProcedure { get; set; } // ErrorProcedure. The name of the stored procedure or trigger where the error occurred.
        public int? ErrorLine { get; set; } // ErrorLine. The line number at which the error occurred.
        public string ErrorMessage { get; set; } // ErrorMessage. The message text of the error that occurred.
        
        public ErrorLog()
        {
            ErrorTime = System.DateTime.Now;
        }
    }

}
