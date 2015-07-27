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
    // Employee
    internal class HumanResources_EmployeeConfiguration : EntityTypeConfiguration<HumanResources_Employee>
    {
        public HumanResources_EmployeeConfiguration(string schema = "HumanResources")
        {
            ToTable(schema + ".Employee");
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.NationalIdNumber).HasColumnName("NationalIDNumber").IsRequired().HasMaxLength(15);
            Property(x => x.LoginId).HasColumnName("LoginID").IsRequired().HasMaxLength(256);
            Property(x => x.OrganizationNode).HasColumnName("OrganizationNode").IsOptional().HasMaxLength(892);
            Property(x => x.OrganizationLevel).HasColumnName("OrganizationLevel").IsOptional().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.JobTitle).HasColumnName("JobTitle").IsRequired().HasMaxLength(50);
            Property(x => x.BirthDate).HasColumnName("BirthDate").IsRequired();
            Property(x => x.MaritalStatus).HasColumnName("MaritalStatus").IsRequired().IsFixedLength().HasMaxLength(1);
            Property(x => x.Gender).HasColumnName("Gender").IsRequired().IsFixedLength().HasMaxLength(1);
            Property(x => x.HireDate).HasColumnName("HireDate").IsRequired();
            Property(x => x.SalariedFlag).HasColumnName("SalariedFlag").IsRequired();
            Property(x => x.VacationHours).HasColumnName("VacationHours").IsRequired();
            Property(x => x.SickLeaveHours).HasColumnName("SickLeaveHours").IsRequired();
            Property(x => x.CurrentFlag).HasColumnName("CurrentFlag").IsRequired();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
            Property(x => x.Test).HasColumnName("Test").IsOptional().IsFixedLength().HasMaxLength(10);

            // Foreign keys
            HasRequired(a => a.Person_Person).WithOptional(b => b.HumanResources_Employee); // FK_Employee_Person_BusinessEntityID
        }
    }

}
