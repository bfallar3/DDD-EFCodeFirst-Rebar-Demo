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
    internal class HumanResources_VJobCandidateEducationConfiguration : EntityTypeConfiguration<HumanResources_VJobCandidateEducation>
    {
        public HumanResources_VJobCandidateEducationConfiguration(string schema = "HumanResources")
        {
            ToTable(schema + ".vJobCandidateEducation");
            HasKey(x => x.JobCandidateId);

            Property(x => x.JobCandidateId).HasColumnName("JobCandidateID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Edu46Level).HasColumnName("Edu.Level").IsOptional();
            Property(x => x.Edu46StartDate).HasColumnName("Edu.StartDate").IsOptional();
            Property(x => x.Edu46EndDate).HasColumnName("Edu.EndDate").IsOptional();
            Property(x => x.Edu46Degree).HasColumnName("Edu.Degree").IsOptional().HasMaxLength(50);
            Property(x => x.Edu46Major).HasColumnName("Edu.Major").IsOptional().HasMaxLength(50);
            Property(x => x.Edu46Minor).HasColumnName("Edu.Minor").IsOptional().HasMaxLength(50);
            Property(x => x.Edu46Gpa).HasColumnName("Edu.GPA").IsOptional().HasMaxLength(5);
            Property(x => x.Edu46GpaScale).HasColumnName("Edu.GPAScale").IsOptional().HasMaxLength(5);
            Property(x => x.Edu46School).HasColumnName("Edu.School").IsOptional().HasMaxLength(100);
            Property(x => x.Edu46Loc46CountryRegion).HasColumnName("Edu.Loc.CountryRegion").IsOptional().HasMaxLength(100);
            Property(x => x.Edu46Loc46State).HasColumnName("Edu.Loc.State").IsOptional().HasMaxLength(100);
            Property(x => x.Edu46Loc46City).HasColumnName("Edu.Loc.City").IsOptional().HasMaxLength(100);
        }
    }

}
