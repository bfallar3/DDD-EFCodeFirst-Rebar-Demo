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
    // PersonCreditCard
    internal class Sales_PersonCreditCardConfiguration : EntityTypeConfiguration<Sales_PersonCreditCard>
    {
        public Sales_PersonCreditCardConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".PersonCreditCard");
            HasKey(x => new { x.BusinessEntityId, x.CreditCardId });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CreditCardId).HasColumnName("CreditCardID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Person_Person).WithMany(b => b.Sales_PersonCreditCard).HasForeignKey(c => c.BusinessEntityId); // FK_PersonCreditCard_Person_BusinessEntityID
            HasRequired(a => a.Sales_CreditCard).WithMany(b => b.Sales_PersonCreditCard).HasForeignKey(c => c.CreditCardId); // FK_PersonCreditCard_CreditCard_CreditCardID
        }
    }

}
