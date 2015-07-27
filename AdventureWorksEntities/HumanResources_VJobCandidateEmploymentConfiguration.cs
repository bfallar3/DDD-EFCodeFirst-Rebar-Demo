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
    internal class HumanResources_VJobCandidateEmploymentConfiguration : EntityTypeConfiguration<HumanResources_VJobCandidateEmployment>
    {
        public HumanResources_VJobCandidateEmploymentConfiguration(string schema = "HumanResources")
        {
            ToTable(schema + ".vJobCandidateEmployment");
            HasKey(x => x.JobCandidateId);

            Property(x => x.JobCandidateId).HasColumnName("JobCandidateID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Emp46StartDate).HasColumnName("Emp.StartDate").IsOptional();
            Property(x => x.Emp46EndDate).HasColumnName("Emp.EndDate").IsOptional();
            Property(x => x.Emp46OrgName).HasColumnName("Emp.OrgName").IsOptional().HasMaxLength(100);
            Property(x => x.Emp46JobTitle).HasColumnName("Emp.JobTitle").IsOptional().HasMaxLength(100);
            Property(x => x.Emp46Responsibility).HasColumnName("Emp.Responsibility").IsOptional();
            Property(x => x.Emp46FunctionCategory).HasColumnName("Emp.FunctionCategory").IsOptional();
            Property(x => x.Emp46IndustryCategory).HasColumnName("Emp.IndustryCategory").IsOptional();
            Property(x => x.Emp46Loc46CountryRegion).HasColumnName("Emp.Loc.CountryRegion").IsOptional();
            Property(x => x.Emp46Loc46State).HasColumnName("Emp.Loc.State").IsOptional();
            Property(x => x.Emp46Loc46City).HasColumnName("Emp.Loc.City").IsOptional();
        }
    }

}
