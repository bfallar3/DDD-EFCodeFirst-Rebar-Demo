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
    // vJobCandidateEducation
    public class HumanResources_VJobCandidateEducation
    {
        public int JobCandidateId { get; set; } // JobCandidateID
        public string Edu46Level { get; set; } // Edu.Level
        public DateTime? Edu46StartDate { get; set; } // Edu.StartDate
        public DateTime? Edu46EndDate { get; set; } // Edu.EndDate
        public string Edu46Degree { get; set; } // Edu.Degree
        public string Edu46Major { get; set; } // Edu.Major
        public string Edu46Minor { get; set; } // Edu.Minor
        public string Edu46Gpa { get; set; } // Edu.GPA
        public string Edu46GpaScale { get; set; } // Edu.GPAScale
        public string Edu46School { get; set; } // Edu.School
        public string Edu46Loc46CountryRegion { get; set; } // Edu.Loc.CountryRegion
        public string Edu46Loc46State { get; set; } // Edu.Loc.State
        public string Edu46Loc46City { get; set; } // Edu.Loc.City
    }

}
