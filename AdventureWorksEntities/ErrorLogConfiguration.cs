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
    // ErrorLog
    internal class ErrorLogConfiguration : EntityTypeConfiguration<ErrorLog>
    {
        public ErrorLogConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".ErrorLog");
            HasKey(x => x.ErrorLogId);

            Property(x => x.ErrorLogId).HasColumnName("ErrorLogID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ErrorTime).HasColumnName("ErrorTime").IsRequired();
            Property(x => x.UserName).HasColumnName("UserName").IsRequired().HasMaxLength(128);
            Property(x => x.ErrorNumber).HasColumnName("ErrorNumber").IsRequired();
            Property(x => x.ErrorSeverity).HasColumnName("ErrorSeverity").IsOptional();
            Property(x => x.ErrorState).HasColumnName("ErrorState").IsOptional();
            Property(x => x.ErrorProcedure).HasColumnName("ErrorProcedure").IsOptional().HasMaxLength(126);
            Property(x => x.ErrorLine).HasColumnName("ErrorLine").IsOptional();
            Property(x => x.ErrorMessage).HasColumnName("ErrorMessage").IsRequired().HasMaxLength(4000);
        }
    }

}
