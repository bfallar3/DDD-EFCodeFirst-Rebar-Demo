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
    // vJobCandidate
    public class HumanResources_VJobCandidate
    {
        public int JobCandidateId { get; set; } // JobCandidateID
        public int? BusinessEntityId { get; set; } // BusinessEntityID
        public string Name46Prefix { get; set; } // Name.Prefix
        public string Name46First { get; set; } // Name.First
        public string Name46Middle { get; set; } // Name.Middle
        public string Name46Last { get; set; } // Name.Last
        public string Name46Suffix { get; set; } // Name.Suffix
        public string Skills { get; set; } // Skills
        public string Addr46Type { get; set; } // Addr.Type
        public string Addr46Loc46CountryRegion { get; set; } // Addr.Loc.CountryRegion
        public string Addr46Loc46State { get; set; } // Addr.Loc.State
        public string Addr46Loc46City { get; set; } // Addr.Loc.City
        public string Addr46PostalCode { get; set; } // Addr.PostalCode
        public string EMail { get; set; } // EMail
        public string WebSite { get; set; } // WebSite
        public DateTime ModifiedDate { get; set; } // ModifiedDate
    }

}
