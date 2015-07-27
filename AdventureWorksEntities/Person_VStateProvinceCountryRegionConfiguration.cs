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
    // vStateProvinceCountryRegion
    internal class Person_VStateProvinceCountryRegionConfiguration : EntityTypeConfiguration<Person_VStateProvinceCountryRegion>
    {
        public Person_VStateProvinceCountryRegionConfiguration(string schema = "Person")
        {
            ToTable(schema + ".vStateProvinceCountryRegion");
            HasKey(x => new { x.StateProvinceId, x.StateProvinceCode, x.IsOnlyStateProvinceFlag, x.StateProvinceName, x.TerritoryId, x.CountryRegionCode, x.CountryRegionName });

            Property(x => x.StateProvinceId).HasColumnName("StateProvinceID").IsRequired();
            Property(x => x.StateProvinceCode).HasColumnName("StateProvinceCode").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.IsOnlyStateProvinceFlag).HasColumnName("IsOnlyStateProvinceFlag").IsRequired();
            Property(x => x.StateProvinceName).HasColumnName("StateProvinceName").IsRequired().HasMaxLength(50);
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsRequired();
            Property(x => x.CountryRegionCode).HasColumnName("CountryRegionCode").IsRequired().HasMaxLength(3);
            Property(x => x.CountryRegionName).HasColumnName("CountryRegionName").IsRequired().HasMaxLength(50);
        }
    }

}
