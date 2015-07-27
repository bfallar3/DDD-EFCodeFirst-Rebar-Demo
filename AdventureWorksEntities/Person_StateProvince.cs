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
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.13.0.0")]
    public class Person_StateProvince
    {
        public int StateProvinceId { get; set; } // StateProvinceID (Primary key). Primary key for StateProvince records.
        public string StateProvinceCode { get; set; } // StateProvinceCode. ISO standard state or province code.
        public string CountryRegionCode { get; set; } // CountryRegionCode. ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode.
        public bool IsOnlyStateProvinceFlag { get; set; } // IsOnlyStateProvinceFlag. 0 = StateProvinceCode exists. 1 = StateProvinceCode unavailable, using CountryRegionCode.
        public string Name { get; set; } // Name. State or province description.
        public int TerritoryId { get; set; } // TerritoryID. ID of the territory in which the state or province is located. Foreign key to SalesTerritory.SalesTerritoryID.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Person_Address> Person_Address { get; set; } // Address.FK_Address_StateProvince_StateProvinceID
        public virtual ICollection<Sales_SalesTaxRate> Sales_SalesTaxRate { get; set; } // SalesTaxRate.FK_SalesTaxRate_StateProvince_StateProvinceID

        // Foreign keys
        public virtual Person_CountryRegion Person_CountryRegion { get; set; } // FK_StateProvince_CountryRegion_CountryRegionCode
        public virtual Sales_SalesTerritory Sales_SalesTerritory { get; set; } // FK_StateProvince_SalesTerritory_TerritoryID
        
        public Person_StateProvince()
        {
            IsOnlyStateProvinceFlag = true;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Person_Address = new List<Person_Address>();
            Sales_SalesTaxRate = new List<Sales_SalesTaxRate>();
        }
    }

}
