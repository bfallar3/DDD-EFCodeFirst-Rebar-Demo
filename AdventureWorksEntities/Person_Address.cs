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
    // Address
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.13.0.0")]
    public class Person_Address
    {
        public int AddressId { get; set; } // AddressID (Primary key). Primary key for Address records.
        public string AddressLine1 { get; set; } // AddressLine1. First street address line.
        public string AddressLine2 { get; set; } // AddressLine2. Second street address line.
        public string City { get; set; } // City. Name of the city.
        public int StateProvinceId { get; set; } // StateProvinceID. Unique identification number for the state or province. Foreign key to StateProvince table.
        public string PostalCode { get; set; } // PostalCode. Postal code for the street address.
        public System.Data.Entity.Spatial.DbGeography SpatialLocation { get; set; } // SpatialLocation. Latitude and longitude of this address.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Person_BusinessEntityAddress> Person_BusinessEntityAddress { get; set; } // Many to many mapping
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeader_BillToAddressId { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_Address_BillToAddressID
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeader_ShipToAddressId { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_Address_ShipToAddressID

        // Foreign keys
        public virtual Person_StateProvince Person_StateProvince { get; set; } // FK_Address_StateProvince_StateProvinceID
        
        public Person_Address()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Person_BusinessEntityAddress = new List<Person_BusinessEntityAddress>();
            Sales_SalesOrderHeader_BillToAddressId = new List<Sales_SalesOrderHeader>();
            Sales_SalesOrderHeader_ShipToAddressId = new List<Sales_SalesOrderHeader>();
        }
    }

}
