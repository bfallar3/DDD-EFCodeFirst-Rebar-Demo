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
    // BusinessEntity
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.13.0.0")]
    public class Person_BusinessEntity
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key for all customers, vendors, and employees.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Person_BusinessEntityAddress> Person_BusinessEntityAddress { get; set; } // Many to many mapping
        public virtual ICollection<Person_BusinessEntityContact> Person_BusinessEntityContact { get; set; } // Many to many mapping
        public virtual Person_Person Person_Person { get; set; } // Person.FK_Person_BusinessEntity_BusinessEntityID
        public virtual Purchasing_Vendor Purchasing_Vendor { get; set; } // Vendor.FK_Vendor_BusinessEntity_BusinessEntityID
        public virtual Sales_Store Sales_Store { get; set; } // Store.FK_Store_BusinessEntity_BusinessEntityID
        
        public Person_BusinessEntity()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Person_BusinessEntityAddress = new List<Person_BusinessEntityAddress>();
            Person_BusinessEntityContact = new List<Person_BusinessEntityContact>();
        }
    }

}
