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
    public interface IAdventureWorksContext : IDisposable
    {
        IDbSet<AwBuildVersion> AwBuildVersions { get; set; } // AWBuildVersion
        IDbSet<DatabaseLog> DatabaseLogs { get; set; } // DatabaseLog
        IDbSet<ErrorLog> ErrorLogs { get; set; } // ErrorLog
        IDbSet<HumanResources_Department> HumanResources_Department { get; set; } // Department
        IDbSet<HumanResources_Employee> HumanResources_Employee { get; set; } // Employee
        IDbSet<HumanResources_EmployeeDepartmentHistory> HumanResources_EmployeeDepartmentHistory { get; set; } // EmployeeDepartmentHistory
        IDbSet<HumanResources_EmployeePayHistory> HumanResources_EmployeePayHistory { get; set; } // EmployeePayHistory
        IDbSet<HumanResources_JobCandidate> HumanResources_JobCandidate { get; set; } // JobCandidate
        IDbSet<HumanResources_Shift> HumanResources_Shift { get; set; } // Shift
        IDbSet<HumanResources_VEmployee> HumanResources_VEmployee { get; set; } // vEmployee
        IDbSet<HumanResources_VEmployeeDepartment> HumanResources_VEmployeeDepartment { get; set; } // vEmployeeDepartment
        IDbSet<HumanResources_VEmployeeDepartmentHistory> HumanResources_VEmployeeDepartmentHistory { get; set; } // vEmployeeDepartmentHistory
        IDbSet<HumanResources_VJobCandidate> HumanResources_VJobCandidate { get; set; } // vJobCandidate
        IDbSet<HumanResources_VJobCandidateEducation> HumanResources_VJobCandidateEducation { get; set; } // vJobCandidateEducation
        IDbSet<HumanResources_VJobCandidateEmployment> HumanResources_VJobCandidateEmployment { get; set; } // vJobCandidateEmployment
        IDbSet<Person_Address> Person_Address { get; set; } // Address
        IDbSet<Person_AddressType> Person_AddressType { get; set; } // AddressType
        IDbSet<Person_BusinessEntity> Person_BusinessEntity { get; set; } // BusinessEntity
        IDbSet<Person_BusinessEntityAddress> Person_BusinessEntityAddress { get; set; } // BusinessEntityAddress
        IDbSet<Person_BusinessEntityContact> Person_BusinessEntityContact { get; set; } // BusinessEntityContact
        IDbSet<Person_ContactType> Person_ContactType { get; set; } // ContactType
        IDbSet<Person_CountryRegion> Person_CountryRegion { get; set; } // CountryRegion
        IDbSet<Person_EmailAddress> Person_EmailAddress { get; set; } // EmailAddress
        IDbSet<Person_Password> Person_Password { get; set; } // Password
        IDbSet<Person_Person> Person_Person { get; set; } // Person
        IDbSet<Person_PersonPhone> Person_PersonPhone { get; set; } // PersonPhone
        IDbSet<Person_PhoneNumberType> Person_PhoneNumberType { get; set; } // PhoneNumberType
        IDbSet<Person_StateProvince> Person_StateProvince { get; set; } // StateProvince
        IDbSet<Person_VAdditionalContactInfo> Person_VAdditionalContactInfo { get; set; } // vAdditionalContactInfo
        IDbSet<Person_VStateProvinceCountryRegion> Person_VStateProvinceCountryRegion { get; set; } // vStateProvinceCountryRegion
        IDbSet<Production_BillOfMaterial> Production_BillOfMaterial { get; set; } // BillOfMaterials
        IDbSet<Production_Culture> Production_Culture { get; set; } // Culture
        IDbSet<Production_Document> Production_Document { get; set; } // Document
        IDbSet<Production_Illustration> Production_Illustration { get; set; } // Illustration
        IDbSet<Production_Location> Production_Location { get; set; } // Location
        IDbSet<Production_Product> Production_Product { get; set; } // Product
        IDbSet<Production_ProductCategory> Production_ProductCategory { get; set; } // ProductCategory
        IDbSet<Production_ProductCostHistory> Production_ProductCostHistory { get; set; } // ProductCostHistory
        IDbSet<Production_ProductDescription> Production_ProductDescription { get; set; } // ProductDescription
        IDbSet<Production_ProductDocument> Production_ProductDocument { get; set; } // ProductDocument
        IDbSet<Production_ProductInventory> Production_ProductInventory { get; set; } // ProductInventory
        IDbSet<Production_ProductListPriceHistory> Production_ProductListPriceHistory { get; set; } // ProductListPriceHistory
        IDbSet<Production_ProductModel> Production_ProductModel { get; set; } // ProductModel
        IDbSet<Production_ProductModelIllustration> Production_ProductModelIllustration { get; set; } // ProductModelIllustration
        IDbSet<Production_ProductModelProductDescriptionCulture> Production_ProductModelProductDescriptionCulture { get; set; } // ProductModelProductDescriptionCulture
        IDbSet<Production_ProductPhoto> Production_ProductPhoto { get; set; } // ProductPhoto
        IDbSet<Production_ProductProductPhoto> Production_ProductProductPhoto { get; set; } // ProductProductPhoto
        IDbSet<Production_ProductReview> Production_ProductReview { get; set; } // ProductReview
        IDbSet<Production_ProductSubcategory> Production_ProductSubcategory { get; set; } // ProductSubcategory
        IDbSet<Production_ScrapReason> Production_ScrapReason { get; set; } // ScrapReason
        IDbSet<Production_TransactionHistory> Production_TransactionHistory { get; set; } // TransactionHistory
        IDbSet<Production_TransactionHistoryArchive> Production_TransactionHistoryArchive { get; set; } // TransactionHistoryArchive
        IDbSet<Production_UnitMeasure> Production_UnitMeasure { get; set; } // UnitMeasure
        IDbSet<Production_VProductAndDescription> Production_VProductAndDescription { get; set; } // vProductAndDescription
        IDbSet<Production_VProductModelCatalogDescription> Production_VProductModelCatalogDescription { get; set; } // vProductModelCatalogDescription
        IDbSet<Production_VProductModelInstruction> Production_VProductModelInstruction { get; set; } // vProductModelInstructions
        IDbSet<Production_WorkOrder> Production_WorkOrder { get; set; } // WorkOrder
        IDbSet<Production_WorkOrderRouting> Production_WorkOrderRouting { get; set; } // WorkOrderRouting
        IDbSet<Purchasing_ProductVendor> Purchasing_ProductVendor { get; set; } // ProductVendor
        IDbSet<Purchasing_PurchaseOrderDetail> Purchasing_PurchaseOrderDetail { get; set; } // PurchaseOrderDetail
        IDbSet<Purchasing_PurchaseOrderHeader> Purchasing_PurchaseOrderHeader { get; set; } // PurchaseOrderHeader
        IDbSet<Purchasing_ShipMethod> Purchasing_ShipMethod { get; set; } // ShipMethod
        IDbSet<Purchasing_Vendor> Purchasing_Vendor { get; set; } // Vendor
        IDbSet<Purchasing_VVendorWithAddress> Purchasing_VVendorWithAddress { get; set; } // vVendorWithAddresses
        IDbSet<Purchasing_VVendorWithContact> Purchasing_VVendorWithContact { get; set; } // vVendorWithContacts
        IDbSet<Sales_CountryRegionCurrency> Sales_CountryRegionCurrency { get; set; } // CountryRegionCurrency
        IDbSet<Sales_CreditCard> Sales_CreditCard { get; set; } // CreditCard
        IDbSet<Sales_Currency> Sales_Currency { get; set; } // Currency
        IDbSet<Sales_CurrencyRate> Sales_CurrencyRate { get; set; } // CurrencyRate
        IDbSet<Sales_Customer> Sales_Customer { get; set; } // Customer
        IDbSet<Sales_PersonCreditCard> Sales_PersonCreditCard { get; set; } // PersonCreditCard
        IDbSet<Sales_SalesOrderDetail> Sales_SalesOrderDetail { get; set; } // SalesOrderDetail
        IDbSet<Sales_SalesOrderHeader> Sales_SalesOrderHeader { get; set; } // SalesOrderHeader
        IDbSet<Sales_SalesOrderHeaderSalesReason> Sales_SalesOrderHeaderSalesReason { get; set; } // SalesOrderHeaderSalesReason
        IDbSet<Sales_SalesPerson> Sales_SalesPerson { get; set; } // SalesPerson
        IDbSet<Sales_SalesPersonQuotaHistory> Sales_SalesPersonQuotaHistory { get; set; } // SalesPersonQuotaHistory
        IDbSet<Sales_SalesReason> Sales_SalesReason { get; set; } // SalesReason
        IDbSet<Sales_SalesTaxRate> Sales_SalesTaxRate { get; set; } // SalesTaxRate
        IDbSet<Sales_SalesTerritory> Sales_SalesTerritory { get; set; } // SalesTerritory
        IDbSet<Sales_SalesTerritoryHistory> Sales_SalesTerritoryHistory { get; set; } // SalesTerritoryHistory
        IDbSet<Sales_ShoppingCartItem> Sales_ShoppingCartItem { get; set; } // ShoppingCartItem
        IDbSet<Sales_SpecialOffer> Sales_SpecialOffer { get; set; } // SpecialOffer
        IDbSet<Sales_SpecialOfferProduct> Sales_SpecialOfferProduct { get; set; } // SpecialOfferProduct
        IDbSet<Sales_Store> Sales_Store { get; set; } // Store
        IDbSet<Sales_VIndividualCustomer> Sales_VIndividualCustomer { get; set; } // vIndividualCustomer
        IDbSet<Sales_VPersonDemographic> Sales_VPersonDemographic { get; set; } // vPersonDemographics
        IDbSet<Sales_VSalesPerson> Sales_VSalesPerson { get; set; } // vSalesPerson
        IDbSet<Sales_VSalesPersonSalesByFiscalYear> Sales_VSalesPersonSalesByFiscalYear { get; set; } // vSalesPersonSalesByFiscalYears
        IDbSet<Sales_VStoreWithAddress> Sales_VStoreWithAddress { get; set; } // vStoreWithAddresses
        IDbSet<Sales_VStoreWithContact> Sales_VStoreWithContact { get; set; } // vStoreWithContacts
        IDbSet<Sales_VStoreWithDemographic> Sales_VStoreWithDemographic { get; set; } // vStoreWithDemographics
        IDbSet<Sysdiagram> Sysdiagrams { get; set; } // sysdiagrams

        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        
        // Stored Procedures
        List<UspGetBillOfMaterialsReturnModel> UspGetBillOfMaterials(int? startProductId, DateTime? checkDate, out int procResult);
        List<UspGetEmployeeManagersReturnModel> UspGetEmployeeManagers(int? businessEntityId, out int procResult);
        List<UspGetManagerEmployeesReturnModel> UspGetManagerEmployees(int? businessEntityId, out int procResult);
        List<UspGetWhereUsedProductIdReturnModel> UspGetWhereUsedProductId(int? startProductId, DateTime? checkDate, out int procResult);
        int UspLogError(out int? errorLogId);
        int UspPrintError();
        int UspSearchCandidateResumes(string searchString, bool? useInflectional, bool? useThesaurus, int? language);
        int HumanResources_UspUpdateEmployeeHireInfo(int? businessEntityId, string jobTitle, DateTime? hireDate, DateTime? rateChangeDate, decimal? rate, byte? payFrequency, bool? currentFlag);
        int HumanResources_UspUpdateEmployeeLogin(int? businessEntityId, string organizationNode, string loginId, string jobTitle, DateTime? hireDate, bool? currentFlag);
        int HumanResources_UspUpdateEmployeePersonalInfo(int? businessEntityId, string nationalIdNumber, DateTime? birthDate, string maritalStatus, string gender);
    }

}
