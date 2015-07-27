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
    // vPersonDemographics
    public class Sales_VPersonDemographic
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID
        public decimal? TotalPurchaseYtd { get; set; } // TotalPurchaseYTD
        public DateTime? DateFirstPurchase { get; set; } // DateFirstPurchase
        public DateTime? BirthDate { get; set; } // BirthDate
        public string MaritalStatus { get; set; } // MaritalStatus
        public string YearlyIncome { get; set; } // YearlyIncome
        public string Gender { get; set; } // Gender
        public int? TotalChildren { get; set; } // TotalChildren
        public int? NumberChildrenAtHome { get; set; } // NumberChildrenAtHome
        public string Education { get; set; } // Education
        public string Occupation { get; set; } // Occupation
        public bool? HomeOwnerFlag { get; set; } // HomeOwnerFlag
        public int? NumberCarsOwned { get; set; } // NumberCarsOwned
    }

}
