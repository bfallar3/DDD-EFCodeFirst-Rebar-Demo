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
    // BusinessEntityAddress
    public class Person_BusinessEntityAddress
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key. Foreign key to BusinessEntity.BusinessEntityID.
        public int AddressId { get; set; } // AddressID (Primary key). Primary key. Foreign key to Address.AddressID.
        public int AddressTypeId { get; set; } // AddressTypeID (Primary key). Primary key. Foreign key to AddressType.AddressTypeID.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Person_Address Person_Address { get; set; } // FK_BusinessEntityAddress_Address_AddressID
        public virtual Person_AddressType Person_AddressType { get; set; } // FK_BusinessEntityAddress_AddressType_AddressTypeID
        public virtual Person_BusinessEntity Person_BusinessEntity { get; set; } // FK_BusinessEntityAddress_BusinessEntity_BusinessEntityID
        
        public Person_BusinessEntityAddress()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

}
