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
    // JobCandidate
    public class HumanResources_JobCandidate
    {
        public int JobCandidateId { get; set; } // JobCandidateID (Primary key). Primary key for JobCandidate records.
        public int? BusinessEntityId { get; set; } // BusinessEntityID. Employee identification number if applicant was hired. Foreign key to Employee.BusinessEntityID.
        public string Resume { get; set; } // Resume. Résumé in XML format.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual HumanResources_Employee HumanResources_Employee { get; set; } // FK_JobCandidate_Employee_BusinessEntityID
        
        public HumanResources_JobCandidate()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
