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
    // SalesTaxRate
    public class Sales_SalesTaxRate
    {
        public int SalesTaxRateId { get; set; } // SalesTaxRateID (Primary key). Primary key for SalesTaxRate records.
        public int StateProvinceId { get; set; } // StateProvinceID. State, province, or country/region the sales tax applies to.
        public byte TaxType { get; set; } // TaxType. 1 = Tax applied to retail transactions, 2 = Tax applied to wholesale transactions, 3 = Tax applied to all sales (retail and wholesale) transactions.
        public decimal TaxRate { get; set; } // TaxRate. Tax rate amount.
        public string Name { get; set; } // Name. Tax rate description.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Person_StateProvince Person_StateProvince { get; set; } // FK_SalesTaxRate_StateProvince_StateProvinceID
        
        public Sales_SalesTaxRate()
        {
            TaxRate = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

}
