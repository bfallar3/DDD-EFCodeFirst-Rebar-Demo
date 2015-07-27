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
    internal class HumanResources_VJobCandidateConfiguration : EntityTypeConfiguration<HumanResources_VJobCandidate>
    {
        public HumanResources_VJobCandidateConfiguration(string schema = "HumanResources")
        {
            ToTable(schema + ".vJobCandidate");
            HasKey(x => new { x.JobCandidateId, x.ModifiedDate });

            Property(x => x.JobCandidateId).HasColumnName("JobCandidateID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsOptional();
            Property(x => x.Name46Prefix).HasColumnName("Name.Prefix").IsOptional().HasMaxLength(30);
            Property(x => x.Name46First).HasColumnName("Name.First").IsOptional().HasMaxLength(30);
            Property(x => x.Name46Middle).HasColumnName("Name.Middle").IsOptional().HasMaxLength(30);
            Property(x => x.Name46Last).HasColumnName("Name.Last").IsOptional().HasMaxLength(30);
            Property(x => x.Name46Suffix).HasColumnName("Name.Suffix").IsOptional().HasMaxLength(30);
            Property(x => x.Skills).HasColumnName("Skills").IsOptional();
            Property(x => x.Addr46Type).HasColumnName("Addr.Type").IsOptional().HasMaxLength(30);
            Property(x => x.Addr46Loc46CountryRegion).HasColumnName("Addr.Loc.CountryRegion").IsOptional().HasMaxLength(100);
            Property(x => x.Addr46Loc46State).HasColumnName("Addr.Loc.State").IsOptional().HasMaxLength(100);
            Property(x => x.Addr46Loc46City).HasColumnName("Addr.Loc.City").IsOptional().HasMaxLength(100);
            Property(x => x.Addr46PostalCode).HasColumnName("Addr.PostalCode").IsOptional().HasMaxLength(20);
            Property(x => x.EMail).HasColumnName("EMail").IsOptional();
            Property(x => x.WebSite).HasColumnName("WebSite").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

}
