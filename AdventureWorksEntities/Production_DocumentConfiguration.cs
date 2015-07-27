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
    // Document
    internal class Production_DocumentConfiguration : EntityTypeConfiguration<Production_Document>
    {
        public Production_DocumentConfiguration(string schema = "Production")
        {
            ToTable(schema + ".Document");
            HasKey(x => x.DocumentNode);

            Property(x => x.DocumentNode).HasColumnName("DocumentNode").IsRequired().HasMaxLength(892).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.DocumentLevel).HasColumnName("DocumentLevel").IsOptional().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.Title).HasColumnName("Title").IsRequired().HasMaxLength(50);
            Property(x => x.Owner).HasColumnName("Owner").IsRequired();
            Property(x => x.FolderFlag).HasColumnName("FolderFlag").IsRequired();
            Property(x => x.FileName).HasColumnName("FileName").IsRequired().HasMaxLength(400);
            Property(x => x.FileExtension).HasColumnName("FileExtension").IsRequired().HasMaxLength(8);
            Property(x => x.Revision).HasColumnName("Revision").IsRequired().IsFixedLength().HasMaxLength(5);
            Property(x => x.ChangeNumber).HasColumnName("ChangeNumber").IsRequired();
            Property(x => x.Status).HasColumnName("Status").IsRequired();
            Property(x => x.DocumentSummary).HasColumnName("DocumentSummary").IsOptional();
            Property(x => x.Document).HasColumnName("Document").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.HumanResources_Employee).WithMany(b => b.Production_Document).HasForeignKey(c => c.Owner); // FK_Document_Employee_Owner
        }
    }

}
