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
    // vStoreWithDemographics
    public class Sales_VStoreWithDemographic
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID
        public string Name { get; set; } // Name
        public decimal? AnnualSales { get; set; } // AnnualSales
        public decimal? AnnualRevenue { get; set; } // AnnualRevenue
        public string BankName { get; set; } // BankName
        public string BusinessType { get; set; } // BusinessType
        public int? YearOpened { get; set; } // YearOpened
        public string Specialty { get; set; } // Specialty
        public int? SquareFeet { get; set; } // SquareFeet
        public string Brands { get; set; } // Brands
        public string Internet { get; set; } // Internet
        public int? NumberEmployees { get; set; } // NumberEmployees
    }

}
