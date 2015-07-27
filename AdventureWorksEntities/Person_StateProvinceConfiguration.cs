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
    // StateProvince
    internal class Person_StateProvinceConfiguration : EntityTypeConfiguration<Person_StateProvince>
    {
        public Person_StateProvinceConfiguration(string schema = "Person")
        {
            ToTable(schema + ".StateProvince");
            HasKey(x => x.StateProvinceId);

            Property(x => x.StateProvinceId).HasColumnName("StateProvinceID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.StateProvinceCode).HasColumnName("StateProvinceCode").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.CountryRegionCode).HasColumnName("CountryRegionCode").IsRequired().HasMaxLength(3);
            Property(x => x.IsOnlyStateProvinceFlag).HasColumnName("IsOnlyStateProvinceFlag").IsRequired();
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsRequired();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Person_CountryRegion).WithMany(b => b.Person_StateProvince).HasForeignKey(c => c.CountryRegionCode); // FK_StateProvince_CountryRegion_CountryRegionCode
            HasRequired(a => a.Sales_SalesTerritory).WithMany(b => b.Person_StateProvince).HasForeignKey(c => c.TerritoryId); // FK_StateProvince_SalesTerritory_TerritoryID
        }
    }

}
