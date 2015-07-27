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
    // vAdditionalContactInfo
    public class Person_VAdditionalContactInfo
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID
        public string FirstName { get; set; } // FirstName
        public string MiddleName { get; set; } // MiddleName
        public string LastName { get; set; } // LastName
        public string TelephoneNumber { get; set; } // TelephoneNumber
        public string TelephoneSpecialInstructions { get; set; } // TelephoneSpecialInstructions
        public string Street { get; set; } // Street
        public string City { get; set; } // City
        public string StateProvince { get; set; } // StateProvince
        public string PostalCode { get; set; } // PostalCode
        public string CountryRegion { get; set; } // CountryRegion
        public string HomeAddressSpecialInstructions { get; set; } // HomeAddressSpecialInstructions
        public string EMailAddress { get; set; } // EMailAddress
        public string EMailSpecialInstructions { get; set; } // EMailSpecialInstructions
        public string EMailTelephoneNumber { get; set; } // EMailTelephoneNumber
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate
    }

}
