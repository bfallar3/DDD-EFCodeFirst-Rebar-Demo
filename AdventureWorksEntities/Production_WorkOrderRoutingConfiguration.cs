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
    // WorkOrderRouting
    internal class Production_WorkOrderRoutingConfiguration : EntityTypeConfiguration<Production_WorkOrderRouting>
    {
        public Production_WorkOrderRoutingConfiguration(string schema = "Production")
        {
            ToTable(schema + ".WorkOrderRouting");
            HasKey(x => new { x.WorkOrderId, x.ProductId, x.OperationSequence });

            Property(x => x.WorkOrderId).HasColumnName("WorkOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.OperationSequence).HasColumnName("OperationSequence").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.LocationId).HasColumnName("LocationID").IsRequired();
            Property(x => x.ScheduledStartDate).HasColumnName("ScheduledStartDate").IsRequired();
            Property(x => x.ScheduledEndDate).HasColumnName("ScheduledEndDate").IsRequired();
            Property(x => x.ActualStartDate).HasColumnName("ActualStartDate").IsOptional();
            Property(x => x.ActualEndDate).HasColumnName("ActualEndDate").IsOptional();
            Property(x => x.ActualResourceHrs).HasColumnName("ActualResourceHrs").IsOptional().HasPrecision(9,4);
            Property(x => x.PlannedCost).HasColumnName("PlannedCost").IsRequired().HasPrecision(19,4);
            Property(x => x.ActualCost).HasColumnName("ActualCost").IsOptional().HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_WorkOrder).WithMany(b => b.Production_WorkOrderRouting).HasForeignKey(c => c.WorkOrderId); // FK_WorkOrderRouting_WorkOrder_WorkOrderID
            HasRequired(a => a.Production_Location).WithMany(b => b.Production_WorkOrderRouting).HasForeignKey(c => c.LocationId); // FK_WorkOrderRouting_Location_LocationID
        }
    }

}
