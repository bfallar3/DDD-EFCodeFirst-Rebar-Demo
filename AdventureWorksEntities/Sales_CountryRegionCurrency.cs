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
    // CountryRegionCurrency
    public class Sales_CountryRegionCurrency
    {
        public string CountryRegionCode { get; set; } // CountryRegionCode (Primary key). ISO code for countries and regions. Foreign key to CountryRegion.CountryRegionCode.
        public string CurrencyCode { get; set; } // CurrencyCode (Primary key). ISO standard currency code. Foreign key to Currency.CurrencyCode.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Person_CountryRegion Person_CountryRegion { get; set; } // FK_CountryRegionCurrency_CountryRegion_CountryRegionCode
        public virtual Sales_Currency Sales_Currency { get; set; } // FK_CountryRegionCurrency_Currency_CurrencyCode
        
        public Sales_CountryRegionCurrency()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
