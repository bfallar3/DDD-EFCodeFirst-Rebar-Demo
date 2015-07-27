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
    // DatabaseLog
    internal class DatabaseLogConfiguration : EntityTypeConfiguration<DatabaseLog>
    {
        public DatabaseLogConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".DatabaseLog");
            HasKey(x => x.DatabaseLogId);

            Property(x => x.DatabaseLogId).HasColumnName("DatabaseLogID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.PostTime).HasColumnName("PostTime").IsRequired();
            Property(x => x.DatabaseUser).HasColumnName("DatabaseUser").IsRequired().HasMaxLength(128);
            Property(x => x.Event).HasColumnName("Event").IsRequired().HasMaxLength(128);
            Property(x => x.Schema).HasColumnName("Schema").IsOptional().HasMaxLength(128);
            Property(x => x.Object).HasColumnName("Object").IsOptional().HasMaxLength(128);
            Property(x => x.Tsql).HasColumnName("TSQL").IsRequired();
            Property(x => x.XmlEvent).HasColumnName("XmlEvent").IsRequired();
        }
    }

}
