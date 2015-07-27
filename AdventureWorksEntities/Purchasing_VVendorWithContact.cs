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
    // vVendorWithContacts
    public class Purchasing_VVendorWithContact
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID
        public string Name { get; set; } // Name
        public string ContactType { get; set; } // ContactType
        public string Title { get; set; } // Title
        public string FirstName { get; set; } // FirstName
        public string MiddleName { get; set; } // MiddleName
        public string LastName { get; set; } // LastName
        public string Suffix { get; set; } // Suffix
        public string PhoneNumber { get; set; } // PhoneNumber
        public string PhoneNumberType { get; set; } // PhoneNumberType
        public string EmailAddress { get; set; } // EmailAddress
        public int EmailPromotion { get; set; } // EmailPromotion
    }

}
