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
    // vSalesPersonSalesByFiscalYears
    public class Sales_VSalesPersonSalesByFiscalYear
    {
        public int? SalesPersonId { get; set; } // SalesPersonID
        public string FullName { get; set; } // FullName
        public string JobTitle { get; set; } // JobTitle
        public string SalesTerritory { get; set; } // SalesTerritory
        public decimal? C2002 { get; set; } // 2002
        public decimal? C2003 { get; set; } // 2003
        public decimal? C2004 { get; set; } // 2004
    }

}
