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
    // vJobCandidateEmployment
    public class HumanResources_VJobCandidateEmployment
    {
        public int JobCandidateId { get; set; } // JobCandidateID
        public DateTime? Emp46StartDate { get; set; } // Emp.StartDate
        public DateTime? Emp46EndDate { get; set; } // Emp.EndDate
        public string Emp46OrgName { get; set; } // Emp.OrgName
        public string Emp46JobTitle { get; set; } // Emp.JobTitle
        public string Emp46Responsibility { get; set; } // Emp.Responsibility
        public string Emp46FunctionCategory { get; set; } // Emp.FunctionCategory
        public string Emp46IndustryCategory { get; set; } // Emp.IndustryCategory
        public string Emp46Loc46CountryRegion { get; set; } // Emp.Loc.CountryRegion
        public string Emp46Loc46State { get; set; } // Emp.Loc.State
        public string Emp46Loc46City { get; set; } // Emp.Loc.City
    }

}
