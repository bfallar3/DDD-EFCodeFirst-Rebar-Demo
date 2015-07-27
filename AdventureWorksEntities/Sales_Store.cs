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
    // Store
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.13.0.0")]
    public class Sales_Store
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key. Foreign key to Customer.BusinessEntityID.
        public string Name { get; set; } // Name. Name of the store.
        public int? SalesPersonId { get; set; } // SalesPersonID. ID of the sales person assigned to the customer. Foreign key to SalesPerson.BusinessEntityID.
        public string Demographics { get; set; } // Demographics. Demographic informationg about the store such as the number of employees, annual sales and store type.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Sales_Customer> Sales_Customer { get; set; } // Customer.FK_Customer_Store_StoreID

        // Foreign keys
        public virtual Person_BusinessEntity Person_BusinessEntity { get; set; } // FK_Store_BusinessEntity_BusinessEntityID
        public virtual Sales_SalesPerson Sales_SalesPerson { get; set; } // FK_Store_SalesPerson_SalesPersonID
        
        public Sales_Store()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Sales_Customer = new List<Sales_Customer>();
        }
    }

}
