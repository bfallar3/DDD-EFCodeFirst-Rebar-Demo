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
    // Product
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.13.0.0")]
    public class Production_Product
    {
        public int ProductId { get; set; } // ProductID (Primary key). Primary key for Product records.
        public string Name { get; set; } // Name. Name of the product.
        public string ProductNumber { get; set; } // ProductNumber. Unique product identification number.
        public bool MakeFlag { get; set; } // MakeFlag. 0 = Product is purchased, 1 = Product is manufactured in-house.
        public bool FinishedGoodsFlag { get; set; } // FinishedGoodsFlag. 0 = Product is not a salable item. 1 = Product is salable.
        public string Color { get; set; } // Color. Product color.
        public short SafetyStockLevel { get; set; } // SafetyStockLevel. Minimum inventory quantity.
        public short ReorderPoint { get; set; } // ReorderPoint. Inventory level that triggers a purchase order or work order.
        public decimal StandardCost { get; set; } // StandardCost. Standard cost of the product.
        public decimal ListPrice { get; set; } // ListPrice. Selling price.
        public string Size { get; set; } // Size. Product size.
        public string SizeUnitMeasureCode { get; set; } // SizeUnitMeasureCode. Unit of measure for Size column.
        public string WeightUnitMeasureCode { get; set; } // WeightUnitMeasureCode. Unit of measure for Weight column.
        public decimal? Weight { get; set; } // Weight. Product weight.
        public int DaysToManufacture { get; set; } // DaysToManufacture. Number of days required to manufacture the product.
        public string ProductLine { get; set; } // ProductLine. R = Road, M = Mountain, T = Touring, S = Standard
        public string Class { get; set; } // Class. H = High, M = Medium, L = Low
        public string Style { get; set; } // Style. W = Womens, M = Mens, U = Universal
        public int? ProductSubcategoryId { get; set; } // ProductSubcategoryID. Product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID.
        public int? ProductModelId { get; set; } // ProductModelID. Product is a member of this product model. Foreign key to ProductModel.ProductModelID.
        public DateTime SellStartDate { get; set; } // SellStartDate. Date the product was available for sale.
        public DateTime? SellEndDate { get; set; } // SellEndDate. Date the product was no longer available for sale.
        public DateTime? DiscontinuedDate { get; set; } // DiscontinuedDate. Date the product was discontinued.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Production_BillOfMaterial> Production_BillOfMaterial_ComponentId { get; set; } // BillOfMaterials.FK_BillOfMaterials_Product_ComponentID
        public virtual ICollection<Production_BillOfMaterial> Production_BillOfMaterial_ProductAssemblyId { get; set; } // BillOfMaterials.FK_BillOfMaterials_Product_ProductAssemblyID
        public virtual ICollection<Production_ProductCostHistory> Production_ProductCostHistory { get; set; } // Many to many mapping
        public virtual ICollection<Production_ProductDocument> Production_ProductDocument { get; set; } // Many to many mapping
        public virtual ICollection<Production_ProductInventory> Production_ProductInventory { get; set; } // Many to many mapping
        public virtual ICollection<Production_ProductListPriceHistory> Production_ProductListPriceHistory { get; set; } // Many to many mapping
        public virtual ICollection<Production_ProductProductPhoto> Production_ProductProductPhoto { get; set; } // Many to many mapping
        public virtual ICollection<Production_ProductReview> Production_ProductReview { get; set; } // ProductReview.FK_ProductReview_Product_ProductID
        public virtual ICollection<Production_TransactionHistory> Production_TransactionHistory { get; set; } // TransactionHistory.FK_TransactionHistory_Product_ProductID
        public virtual ICollection<Production_WorkOrder> Production_WorkOrder { get; set; } // WorkOrder.FK_WorkOrder_Product_ProductID
        public virtual ICollection<Purchasing_ProductVendor> Purchasing_ProductVendor { get; set; } // Many to many mapping
        public virtual ICollection<Purchasing_PurchaseOrderDetail> Purchasing_PurchaseOrderDetail { get; set; } // PurchaseOrderDetail.FK_PurchaseOrderDetail_Product_ProductID
        public virtual ICollection<Sales_ShoppingCartItem> Sales_ShoppingCartItem { get; set; } // ShoppingCartItem.FK_ShoppingCartItem_Product_ProductID
        public virtual ICollection<Sales_SpecialOfferProduct> Sales_SpecialOfferProduct { get; set; } // Many to many mapping

        // Foreign keys
        public virtual Production_ProductModel Production_ProductModel { get; set; } // FK_Product_ProductModel_ProductModelID
        public virtual Production_ProductSubcategory Production_ProductSubcategory { get; set; } // FK_Product_ProductSubcategory_ProductSubcategoryID
        public virtual Production_UnitMeasure Production_UnitMeasure_SizeUnitMeasureCode { get; set; } // FK_Product_UnitMeasure_SizeUnitMeasureCode
        public virtual Production_UnitMeasure Production_UnitMeasure_WeightUnitMeasureCode { get; set; } // FK_Product_UnitMeasure_WeightUnitMeasureCode
        
        public Production_Product()
        {
            MakeFlag = true;
            FinishedGoodsFlag = true;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Production_BillOfMaterial_ComponentId = new List<Production_BillOfMaterial>();
            Production_BillOfMaterial_ProductAssemblyId = new List<Production_BillOfMaterial>();
            Production_ProductCostHistory = new List<Production_ProductCostHistory>();
            Production_ProductDocument = new List<Production_ProductDocument>();
            Production_ProductInventory = new List<Production_ProductInventory>();
            Production_ProductListPriceHistory = new List<Production_ProductListPriceHistory>();
            Production_ProductProductPhoto = new List<Production_ProductProductPhoto>();
            Production_ProductReview = new List<Production_ProductReview>();
            Purchasing_ProductVendor = new List<Purchasing_ProductVendor>();
            Purchasing_PurchaseOrderDetail = new List<Purchasing_PurchaseOrderDetail>();
            Sales_ShoppingCartItem = new List<Sales_ShoppingCartItem>();
            Sales_SpecialOfferProduct = new List<Sales_SpecialOfferProduct>();
            Production_TransactionHistory = new List<Production_TransactionHistory>();
            Production_WorkOrder = new List<Production_WorkOrder>();
        }
    }

}
