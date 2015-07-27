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
    // PersonPhone
    public class Person_PersonPhone
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Business entity identification number. Foreign key to Person.BusinessEntityID.
        public string PhoneNumber { get; set; } // PhoneNumber (Primary key). Telephone number identification number.
        public int PhoneNumberTypeId { get; set; } // PhoneNumberTypeID (Primary key). Kind of phone number. Foreign key to PhoneNumberType.PhoneNumberTypeID.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Person_Person Person_Person { get; set; } // FK_PersonPhone_Person_BusinessEntityID
        public virtual Person_PhoneNumberType Person_PhoneNumberType { get; set; } // FK_PersonPhone_PhoneNumberType_PhoneNumberTypeID
        
        public Person_PersonPhone()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
