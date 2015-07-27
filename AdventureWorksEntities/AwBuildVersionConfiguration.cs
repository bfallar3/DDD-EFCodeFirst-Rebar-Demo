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
    // AWBuildVersion
    internal class AwBuildVersionConfiguration : EntityTypeConfiguration<AwBuildVersion>
    {
        public AwBuildVersionConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".AWBuildVersion");
            HasKey(x => x.SystemInformationId);

            Property(x => x.SystemInformationId).HasColumnName("SystemInformationID").IsRequired();
            Property(x => x.DatabaseVersion).HasColumnName("Database Version").IsRequired().HasMaxLength(25);
            Property(x => x.VersionDate).HasColumnName("VersionDate").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

}
