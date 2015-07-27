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
    // SalesOrderHeader
    internal class Sales_SalesOrderHeaderConfiguration : EntityTypeConfiguration<Sales_SalesOrderHeader>
    {
        public Sales_SalesOrderHeaderConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesOrderHeader");
            HasKey(x => x.SalesOrderId);

            Property(x => x.SalesOrderId).HasColumnName("SalesOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.RevisionNumber).HasColumnName("RevisionNumber").IsRequired();
            Property(x => x.OrderDate).HasColumnName("OrderDate").IsRequired();
            Property(x => x.DueDate).HasColumnName("DueDate").IsRequired();
            Property(x => x.ShipDate).HasColumnName("ShipDate").IsOptional();
            Property(x => x.Status).HasColumnName("Status").IsRequired();
            Property(x => x.OnlineOrderFlag).HasColumnName("OnlineOrderFlag").IsRequired();
            Property(x => x.SalesOrderNumber).HasColumnName("SalesOrderNumber").IsRequired().HasMaxLength(25).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.PurchaseOrderNumber).HasColumnName("PurchaseOrderNumber").IsOptional().HasMaxLength(25);
            Property(x => x.AccountNumber).HasColumnName("AccountNumber").IsOptional().HasMaxLength(15);
            Property(x => x.CustomerId).HasColumnName("CustomerID").IsRequired();
            Property(x => x.SalesPersonId).HasColumnName("SalesPersonID").IsOptional();
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsOptional();
            Property(x => x.BillToAddressId).HasColumnName("BillToAddressID").IsRequired();
            Property(x => x.ShipToAddressId).HasColumnName("ShipToAddressID").IsRequired();
            Property(x => x.ShipMethodId).HasColumnName("ShipMethodID").IsRequired();
            Property(x => x.CreditCardId).HasColumnName("CreditCardID").IsOptional();
            Property(x => x.CreditCardApprovalCode).HasColumnName("CreditCardApprovalCode").IsOptional().IsUnicode(false).HasMaxLength(15);
            Property(x => x.CurrencyRateId).HasColumnName("CurrencyRateID").IsOptional();
            Property(x => x.SubTotal).HasColumnName("SubTotal").IsRequired().HasPrecision(19,4);
            Property(x => x.TaxAmt).HasColumnName("TaxAmt").IsRequired().HasPrecision(19,4);
            Property(x => x.Freight).HasColumnName("Freight").IsRequired().HasPrecision(19,4);
            Property(x => x.TotalDue).HasColumnName("TotalDue").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.Comment).HasColumnName("Comment").IsOptional().HasMaxLength(128);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_Customer).WithMany(b => b.Sales_SalesOrderHeader).HasForeignKey(c => c.CustomerId); // FK_SalesOrderHeader_Customer_CustomerID
            HasOptional(a => a.Sales_SalesPerson).WithMany(b => b.Sales_SalesOrderHeader).HasForeignKey(c => c.SalesPersonId); // FK_SalesOrderHeader_SalesPerson_SalesPersonID
            HasOptional(a => a.Sales_SalesTerritory).WithMany(b => b.Sales_SalesOrderHeader).HasForeignKey(c => c.TerritoryId); // FK_SalesOrderHeader_SalesTerritory_TerritoryID
            HasRequired(a => a.Person_Address_BillToAddressId).WithMany(b => b.Sales_SalesOrderHeader_BillToAddressId).HasForeignKey(c => c.BillToAddressId); // FK_SalesOrderHeader_Address_BillToAddressID
            HasRequired(a => a.Person_Address_ShipToAddressId).WithMany(b => b.Sales_SalesOrderHeader_ShipToAddressId).HasForeignKey(c => c.ShipToAddressId); // FK_SalesOrderHeader_Address_ShipToAddressID
            HasRequired(a => a.Purchasing_ShipMethod).WithMany(b => b.Sales_SalesOrderHeader).HasForeignKey(c => c.ShipMethodId); // FK_SalesOrderHeader_ShipMethod_ShipMethodID
            HasOptional(a => a.Sales_CreditCard).WithMany(b => b.Sales_SalesOrderHeader).HasForeignKey(c => c.CreditCardId); // FK_SalesOrderHeader_CreditCard_CreditCardID
            HasOptional(a => a.Sales_CurrencyRate).WithMany(b => b.Sales_SalesOrderHeader).HasForeignKey(c => c.CurrencyRateId); // FK_SalesOrderHeader_CurrencyRate_CurrencyRateID
        }
    }

}
