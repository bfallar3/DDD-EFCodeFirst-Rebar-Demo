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
    // CountryRegion
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.13.0.0")]
    public class Person_CountryRegion
    {
        public string CountryRegionCode { get; set; } // CountryRegionCode (Primary key). ISO standard code for countries and regions.
        public string Name { get; set; } // Name. Country or region name.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Person_StateProvince> Person_StateProvince { get; set; } // StateProvince.FK_StateProvince_CountryRegion_CountryRegionCode
        public virtual ICollection<Sales_CountryRegionCurrency> Sales_CountryRegionCurrency { get; set; } // Many to many mapping
        public virtual ICollection<Sales_SalesTerritory> Sales_SalesTerritory { get; set; } // SalesTerritory.FK_SalesTerritory_CountryRegion_CountryRegionCode
        
        public Person_CountryRegion()
        {
            ModifiedDate = System.DateTime.Now;
            Sales_CountryRegionCurrency = new List<Sales_CountryRegionCurrency>();
            Sales_SalesTerritory = new List<Sales_SalesTerritory>();
            Person_StateProvince = new List<Person_StateProvince>();
        }
    }

}
