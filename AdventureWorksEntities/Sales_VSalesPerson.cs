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
    // vSalesPerson
    public class Sales_VSalesPerson
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID
        public string Title { get; set; } // Title
        public string FirstName { get; set; } // FirstName
        public string MiddleName { get; set; } // MiddleName
        public string LastName { get; set; } // LastName
        public string Suffix { get; set; } // Suffix
        public string JobTitle { get; set; } // JobTitle
        public string PhoneNumber { get; set; } // PhoneNumber
        public string PhoneNumberType { get; set; } // PhoneNumberType
        public string EmailAddress { get; set; } // EmailAddress
        public int EmailPromotion { get; set; } // EmailPromotion
        public string AddressLine1 { get; set; } // AddressLine1
        public string AddressLine2 { get; set; } // AddressLine2
        public string City { get; set; } // City
        public string StateProvinceName { get; set; } // StateProvinceName
        public string PostalCode { get; set; } // PostalCode
        public string CountryRegionName { get; set; } // CountryRegionName
        public string TerritoryName { get; set; } // TerritoryName
        public string TerritoryGroup { get; set; } // TerritoryGroup
        public decimal? SalesQuota { get; set; } // SalesQuota
        public decimal SalesYtd { get; set; } // SalesYTD
        public decimal SalesLastYear { get; set; } // SalesLastYear
    }

}
