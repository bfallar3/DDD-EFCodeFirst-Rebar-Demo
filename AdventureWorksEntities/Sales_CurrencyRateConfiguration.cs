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
    internal class Sales_CurrencyRateConfiguration : EntityTypeConfiguration<Sales_CurrencyRate>
    {
        public Sales_CurrencyRateConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".CurrencyRate");
            HasKey(x => x.CurrencyRateId);

            Property(x => x.CurrencyRateId).HasColumnName("CurrencyRateID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CurrencyRateDate).HasColumnName("CurrencyRateDate").IsRequired();
            Property(x => x.FromCurrencyCode).HasColumnName("FromCurrencyCode").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.ToCurrencyCode).HasColumnName("ToCurrencyCode").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.AverageRate).HasColumnName("AverageRate").IsRequired().HasPrecision(19,4);
            Property(x => x.EndOfDayRate).HasColumnName("EndOfDayRate").IsRequired().HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_Currency_FromCurrencyCode).WithMany(b => b.Sales_CurrencyRate_FromCurrencyCode).HasForeignKey(c => c.FromCurrencyCode); // FK_CurrencyRate_Currency_FromCurrencyCode
            HasRequired(a => a.Sales_Currency_ToCurrencyCode).WithMany(b => b.Sales_CurrencyRate_ToCurrencyCode).HasForeignKey(c => c.ToCurrencyCode); // FK_CurrencyRate_Currency_ToCurrencyCode
        }
    }

}
