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
    // CurrencyRate
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.13.0.0")]
    public class Sales_CurrencyRate
    {
        public int CurrencyRateId { get; set; } // CurrencyRateID (Primary key). Primary key for CurrencyRate records.
        public DateTime CurrencyRateDate { get; set; } // CurrencyRateDate. Date and time the exchange rate was obtained.
        public string FromCurrencyCode { get; set; } // FromCurrencyCode. Exchange rate was converted from this currency code.
        public string ToCurrencyCode { get; set; } // ToCurrencyCode. Exchange rate was converted to this currency code.
        public decimal AverageRate { get; set; } // AverageRate. Average exchange rate for the day.
        public decimal EndOfDayRate { get; set; } // EndOfDayRate. Final exchange rate for the day.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeader { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_CurrencyRate_CurrencyRateID

        // Foreign keys
        public virtual Sales_Currency Sales_Currency_FromCurrencyCode { get; set; } // FK_CurrencyRate_Currency_FromCurrencyCode
        public virtual Sales_Currency Sales_Currency_ToCurrencyCode { get; set; } // FK_CurrencyRate_Currency_ToCurrencyCode
        
        public Sales_CurrencyRate()
        {
            ModifiedDate = System.DateTime.Now;
            Sales_SalesOrderHeader = new List<Sales_SalesOrderHeader>();
        }
    }

}
