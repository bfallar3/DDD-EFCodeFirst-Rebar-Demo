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
    // vProductModelInstructions
    internal class Production_VProductModelInstructionConfiguration : EntityTypeConfiguration<Production_VProductModelInstruction>
    {
        public Production_VProductModelInstructionConfiguration(string schema = "Production")
        {
            ToTable(schema + ".vProductModelInstructions");
            HasKey(x => new { x.ProductModelId, x.Name, x.Rowguid, x.ModifiedDate });

            Property(x => x.ProductModelId).HasColumnName("ProductModelID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.Instructions).HasColumnName("Instructions").IsOptional();
            Property(x => x.LocationId).HasColumnName("LocationID").IsOptional();
            Property(x => x.SetupHours).HasColumnName("SetupHours").IsOptional().HasPrecision(9,4);
            Property(x => x.MachineHours).HasColumnName("MachineHours").IsOptional().HasPrecision(9,4);
            Property(x => x.LaborHours).HasColumnName("LaborHours").IsOptional().HasPrecision(9,4);
            Property(x => x.LotSize).HasColumnName("LotSize").IsOptional();
            Property(x => x.Step).HasColumnName("Step").IsOptional().HasMaxLength(1024);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

}
