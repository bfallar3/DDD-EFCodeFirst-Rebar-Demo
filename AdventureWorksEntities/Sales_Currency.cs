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
    // Currency
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.13.0.0")]
    public class Sales_Currency
    {
        public string CurrencyCode { get; set; } // CurrencyCode (Primary key). The ISO code for the Currency.
        public string Name { get; set; } // Name. Currency name.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Sales_CountryRegionCurrency> Sales_CountryRegionCurrency { get; set; } // Many to many mapping
        public virtual ICollection<Sales_CurrencyRate> Sales_CurrencyRate_FromCurrencyCode { get; set; } // CurrencyRate.FK_CurrencyRate_Currency_FromCurrencyCode
        public virtual ICollection<Sales_CurrencyRate> Sales_CurrencyRate_ToCurrencyCode { get; set; } // CurrencyRate.FK_CurrencyRate_Currency_ToCurrencyCode
        
        public Sales_Currency()
        {
            ModifiedDate = System.DateTime.Now;
            Sales_CountryRegionCurrency = new List<Sales_CountryRegionCurrency>();
            Sales_CurrencyRate_FromCurrencyCode = new List<Sales_CurrencyRate>();
            Sales_CurrencyRate_ToCurrencyCode = new List<Sales_CurrencyRate>();
        }
    }

}
