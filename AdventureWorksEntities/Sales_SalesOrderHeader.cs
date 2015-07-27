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
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.13.0.0")]
    public class Sales_SalesOrderHeader
    {
        public int SalesOrderId { get; set; } // SalesOrderID (Primary key). Primary key.
        public byte RevisionNumber { get; set; } // RevisionNumber. Incremental number to track changes to the sales order over time.
        public DateTime OrderDate { get; set; } // OrderDate. Dates the sales order was created.
        public DateTime DueDate { get; set; } // DueDate. Date the order is due to the customer.
        public DateTime? ShipDate { get; set; } // ShipDate. Date the order was shipped to the customer.
        public byte Status { get; set; } // Status. Order current status. 1 = In process; 2 = Approved; 3 = Backordered; 4 = Rejected; 5 = Shipped; 6 = Cancelled
        public bool OnlineOrderFlag { get; set; } // OnlineOrderFlag. 0 = Order placed by sales person. 1 = Order placed online by customer.
        public string SalesOrderNumber { get; set; } // SalesOrderNumber. Unique sales order identification number.
        public string PurchaseOrderNumber { get; set; } // PurchaseOrderNumber. Customer purchase order number reference.
        public string AccountNumber { get; set; } // AccountNumber. Financial accounting number reference.
        public int CustomerId { get; set; } // CustomerID. Customer identification number. Foreign key to Customer.BusinessEntityID.
        public int? SalesPersonId { get; set; } // SalesPersonID. Sales person who created the sales order. Foreign key to SalesPerson.BusinessEntityID.
        public int? TerritoryId { get; set; } // TerritoryID. Territory in which the sale was made. Foreign key to SalesTerritory.SalesTerritoryID.
        public int BillToAddressId { get; set; } // BillToAddressID. Customer billing address. Foreign key to Address.AddressID.
        public int ShipToAddressId { get; set; } // ShipToAddressID. Customer shipping address. Foreign key to Address.AddressID.
        public int ShipMethodId { get; set; } // ShipMethodID. Shipping method. Foreign key to ShipMethod.ShipMethodID.
        public int? CreditCardId { get; set; } // CreditCardID. Credit card identification number. Foreign key to CreditCard.CreditCardID.
        public string CreditCardApprovalCode { get; set; } // CreditCardApprovalCode. Approval code provided by the credit card company.
        public int? CurrencyRateId { get; set; } // CurrencyRateID. Currency exchange rate used. Foreign key to CurrencyRate.CurrencyRateID.
        public decimal SubTotal { get; set; } // SubTotal. Sales subtotal. Computed as SUM(SalesOrderDetail.LineTotal)for the appropriate SalesOrderID.
        public decimal TaxAmt { get; set; } // TaxAmt. Tax amount.
        public decimal Freight { get; set; } // Freight. Shipping cost.
        public decimal TotalDue { get; set; } // TotalDue. Total due from customer. Computed as Subtotal + TaxAmt + Freight.
        public string Comment { get; set; } // Comment. Sales representative comments.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Sales_SalesOrderDetail> Sales_SalesOrderDetail { get; set; } // Many to many mapping
        public virtual ICollection<Sales_SalesOrderHeaderSalesReason> Sales_SalesOrderHeaderSalesReason { get; set; } // Many to many mapping

        // Foreign keys
        public virtual Person_Address Person_Address_BillToAddressId { get; set; } // FK_SalesOrderHeader_Address_BillToAddressID
        public virtual Person_Address Person_Address_ShipToAddressId { get; set; } // FK_SalesOrderHeader_Address_ShipToAddressID
        public virtual Purchasing_ShipMethod Purchasing_ShipMethod { get; set; } // FK_SalesOrderHeader_ShipMethod_ShipMethodID
        public virtual Sales_CreditCard Sales_CreditCard { get; set; } // FK_SalesOrderHeader_CreditCard_CreditCardID
        public virtual Sales_CurrencyRate Sales_CurrencyRate { get; set; } // FK_SalesOrderHeader_CurrencyRate_CurrencyRateID
        public virtual Sales_Customer Sales_Customer { get; set; } // FK_SalesOrderHeader_Customer_CustomerID
        public virtual Sales_SalesPerson Sales_SalesPerson { get; set; } // FK_SalesOrderHeader_SalesPerson_SalesPersonID
        public virtual Sales_SalesTerritory Sales_SalesTerritory { get; set; } // FK_SalesOrderHeader_SalesTerritory_TerritoryID
        
        public Sales_SalesOrderHeader()
        {
            RevisionNumber = 0;
            OrderDate = System.DateTime.Now;
            Status = 1;
            OnlineOrderFlag = true;
            SubTotal = 0.00m;
            TaxAmt = 0.00m;
            Freight = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Sales_SalesOrderDetail = new List<Sales_SalesOrderDetail>();
            Sales_SalesOrderHeaderSalesReason = new List<Sales_SalesOrderHeaderSalesReason>();
        }
    }

}
