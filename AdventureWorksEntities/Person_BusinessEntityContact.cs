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
    // BusinessEntityContact
    public class Person_BusinessEntityContact
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key. Foreign key to BusinessEntity.BusinessEntityID.
        public int PersonId { get; set; } // PersonID (Primary key). Primary key. Foreign key to Person.BusinessEntityID.
        public int ContactTypeId { get; set; } // ContactTypeID (Primary key). Primary key.  Foreign key to ContactType.ContactTypeID.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Person_BusinessEntity Person_BusinessEntity { get; set; } // FK_BusinessEntityContact_BusinessEntity_BusinessEntityID
        public virtual Person_ContactType Person_ContactType { get; set; } // FK_BusinessEntityContact_ContactType_ContactTypeID
        public virtual Person_Person Person_Person { get; set; } // FK_BusinessEntityContact_Person_PersonID
        
        public Person_BusinessEntityContact()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

}
