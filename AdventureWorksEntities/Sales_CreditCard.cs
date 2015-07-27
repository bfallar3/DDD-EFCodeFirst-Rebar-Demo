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
    // CreditCard
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.13.0.0")]
    public class Sales_CreditCard
    {
        public int CreditCardId { get; set; } // CreditCardID (Primary key). Primary key for CreditCard records.
        public string CardType { get; set; } // CardType. Credit card name.
        public string CardNumber { get; set; } // CardNumber. Credit card number.
        public byte ExpMonth { get; set; } // ExpMonth. Credit card expiration month.
        public short ExpYear { get; set; } // ExpYear. Credit card expiration year.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Sales_PersonCreditCard> Sales_PersonCreditCard { get; set; } // Many to many mapping
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeader { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_CreditCard_CreditCardID
        
        public Sales_CreditCard()
        {
            ModifiedDate = System.DateTime.Now;
            Sales_PersonCreditCard = new List<Sales_PersonCreditCard>();
            Sales_SalesOrderHeader = new List<Sales_SalesOrderHeader>();
        }
    }

}
