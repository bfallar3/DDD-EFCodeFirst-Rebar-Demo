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
    public class AdventureWorksContext : DbContext, IAdventureWorksContext
    {
        public IDbSet<AwBuildVersion> AwBuildVersions { get; set; } // AWBuildVersion
        public IDbSet<DatabaseLog> DatabaseLogs { get; set; } // DatabaseLog
        public IDbSet<ErrorLog> ErrorLogs { get; set; } // ErrorLog
        public IDbSet<HumanResources_Department> HumanResources_Department { get; set; } // Department
        public IDbSet<HumanResources_Employee> HumanResources_Employee { get; set; } // Employee
        public IDbSet<HumanResources_EmployeeDepartmentHistory> HumanResources_EmployeeDepartmentHistory { get; set; } // EmployeeDepartmentHistory
        public IDbSet<HumanResources_EmployeePayHistory> HumanResources_EmployeePayHistory { get; set; } // EmployeePayHistory
        public IDbSet<HumanResources_JobCandidate> HumanResources_JobCandidate { get; set; } // JobCandidate
        public IDbSet<HumanResources_Shift> HumanResources_Shift { get; set; } // Shift
        public IDbSet<HumanResources_VEmployee> HumanResources_VEmployee { get; set; } // vEmployee
        public IDbSet<HumanResources_VEmployeeDepartment> HumanResources_VEmployeeDepartment { get; set; } // vEmployeeDepartment
        public IDbSet<HumanResources_VEmployeeDepartmentHistory> HumanResources_VEmployeeDepartmentHistory { get; set; } // vEmployeeDepartmentHistory
        public IDbSet<HumanResources_VJobCandidate> HumanResources_VJobCandidate { get; set; } // vJobCandidate
        public IDbSet<HumanResources_VJobCandidateEducation> HumanResources_VJobCandidateEducation { get; set; } // vJobCandidateEducation
        public IDbSet<HumanResources_VJobCandidateEmployment> HumanResources_VJobCandidateEmployment { get; set; } // vJobCandidateEmployment
        public IDbSet<Person_Address> Person_Address { get; set; } // Address
        public IDbSet<Person_AddressType> Person_AddressType { get; set; } // AddressType
        public IDbSet<Person_BusinessEntity> Person_BusinessEntity { get; set; } // BusinessEntity
        public IDbSet<Person_BusinessEntityAddress> Person_BusinessEntityAddress { get; set; } // BusinessEntityAddress
        public IDbSet<Person_BusinessEntityContact> Person_BusinessEntityContact { get; set; } // BusinessEntityContact
        public IDbSet<Person_ContactType> Person_ContactType { get; set; } // ContactType
        public IDbSet<Person_CountryRegion> Person_CountryRegion { get; set; } // CountryRegion
        public IDbSet<Person_EmailAddress> Person_EmailAddress { get; set; } // EmailAddress
        public IDbSet<Person_Password> Person_Password { get; set; } // Password
        public IDbSet<Person_Person> Person_Person { get; set; } // Person
        public IDbSet<Person_PersonPhone> Person_PersonPhone { get; set; } // PersonPhone
        public IDbSet<Person_PhoneNumberType> Person_PhoneNumberType { get; set; } // PhoneNumberType
        public IDbSet<Person_StateProvince> Person_StateProvince { get; set; } // StateProvince
        public IDbSet<Person_VAdditionalContactInfo> Person_VAdditionalContactInfo { get; set; } // vAdditionalContactInfo
        public IDbSet<Person_VStateProvinceCountryRegion> Person_VStateProvinceCountryRegion { get; set; } // vStateProvinceCountryRegion
        public IDbSet<Production_BillOfMaterial> Production_BillOfMaterial { get; set; } // BillOfMaterials
        public IDbSet<Production_Culture> Production_Culture { get; set; } // Culture
        public IDbSet<Production_Document> Production_Document { get; set; } // Document
        public IDbSet<Production_Illustration> Production_Illustration { get; set; } // Illustration
        public IDbSet<Production_Location> Production_Location { get; set; } // Location
        public IDbSet<Production_Product> Production_Product { get; set; } // Product
        public IDbSet<Production_ProductCategory> Production_ProductCategory { get; set; } // ProductCategory
        public IDbSet<Production_ProductCostHistory> Production_ProductCostHistory { get; set; } // ProductCostHistory
        public IDbSet<Production_ProductDescription> Production_ProductDescription { get; set; } // ProductDescription
        public IDbSet<Production_ProductDocument> Production_ProductDocument { get; set; } // ProductDocument
        public IDbSet<Production_ProductInventory> Production_ProductInventory { get; set; } // ProductInventory
        public IDbSet<Production_ProductListPriceHistory> Production_ProductListPriceHistory { get; set; } // ProductListPriceHistory
        public IDbSet<Production_ProductModel> Production_ProductModel { get; set; } // ProductModel
        public IDbSet<Production_ProductModelIllustration> Production_ProductModelIllustration { get; set; } // ProductModelIllustration
        public IDbSet<Production_ProductModelProductDescriptionCulture> Production_ProductModelProductDescriptionCulture { get; set; } // ProductModelProductDescriptionCulture
        public IDbSet<Production_ProductPhoto> Production_ProductPhoto { get; set; } // ProductPhoto
        public IDbSet<Production_ProductProductPhoto> Production_ProductProductPhoto { get; set; } // ProductProductPhoto
        public IDbSet<Production_ProductReview> Production_ProductReview { get; set; } // ProductReview
        public IDbSet<Production_ProductSubcategory> Production_ProductSubcategory { get; set; } // ProductSubcategory
        public IDbSet<Production_ScrapReason> Production_ScrapReason { get; set; } // ScrapReason
        public IDbSet<Production_TransactionHistory> Production_TransactionHistory { get; set; } // TransactionHistory
        public IDbSet<Production_TransactionHistoryArchive> Production_TransactionHistoryArchive { get; set; } // TransactionHistoryArchive
        public IDbSet<Production_UnitMeasure> Production_UnitMeasure { get; set; } // UnitMeasure
        public IDbSet<Production_VProductAndDescription> Production_VProductAndDescription { get; set; } // vProductAndDescription
        public IDbSet<Production_VProductModelCatalogDescription> Production_VProductModelCatalogDescription { get; set; } // vProductModelCatalogDescription
        public IDbSet<Production_VProductModelInstruction> Production_VProductModelInstruction { get; set; } // vProductModelInstructions
        public IDbSet<Production_WorkOrder> Production_WorkOrder { get; set; } // WorkOrder
        public IDbSet<Production_WorkOrderRouting> Production_WorkOrderRouting { get; set; } // WorkOrderRouting
        public IDbSet<Purchasing_ProductVendor> Purchasing_ProductVendor { get; set; } // ProductVendor
        public IDbSet<Purchasing_PurchaseOrderDetail> Purchasing_PurchaseOrderDetail { get; set; } // PurchaseOrderDetail
        public IDbSet<Purchasing_PurchaseOrderHeader> Purchasing_PurchaseOrderHeader { get; set; } // PurchaseOrderHeader
        public IDbSet<Purchasing_ShipMethod> Purchasing_ShipMethod { get; set; } // ShipMethod
        public IDbSet<Purchasing_Vendor> Purchasing_Vendor { get; set; } // Vendor
        public IDbSet<Purchasing_VVendorWithAddress> Purchasing_VVendorWithAddress { get; set; } // vVendorWithAddresses
        public IDbSet<Purchasing_VVendorWithContact> Purchasing_VVendorWithContact { get; set; } // vVendorWithContacts
        public IDbSet<Sales_CountryRegionCurrency> Sales_CountryRegionCurrency { get; set; } // CountryRegionCurrency
        public IDbSet<Sales_CreditCard> Sales_CreditCard { get; set; } // CreditCard
        public IDbSet<Sales_Currency> Sales_Currency { get; set; } // Currency
        public IDbSet<Sales_CurrencyRate> Sales_CurrencyRate { get; set; } // CurrencyRate
        public IDbSet<Sales_Customer> Sales_Customer { get; set; } // Customer
        public IDbSet<Sales_PersonCreditCard> Sales_PersonCreditCard { get; set; } // PersonCreditCard
        public IDbSet<Sales_SalesOrderDetail> Sales_SalesOrderDetail { get; set; } // SalesOrderDetail
        public IDbSet<Sales_SalesOrderHeader> Sales_SalesOrderHeader { get; set; } // SalesOrderHeader
        public IDbSet<Sales_SalesOrderHeaderSalesReason> Sales_SalesOrderHeaderSalesReason { get; set; } // SalesOrderHeaderSalesReason
        public IDbSet<Sales_SalesPerson> Sales_SalesPerson { get; set; } // SalesPerson
        public IDbSet<Sales_SalesPersonQuotaHistory> Sales_SalesPersonQuotaHistory { get; set; } // SalesPersonQuotaHistory
        public IDbSet<Sales_SalesReason> Sales_SalesReason { get; set; } // SalesReason
        public IDbSet<Sales_SalesTaxRate> Sales_SalesTaxRate { get; set; } // SalesTaxRate
        public IDbSet<Sales_SalesTerritory> Sales_SalesTerritory { get; set; } // SalesTerritory
        public IDbSet<Sales_SalesTerritoryHistory> Sales_SalesTerritoryHistory { get; set; } // SalesTerritoryHistory
        public IDbSet<Sales_ShoppingCartItem> Sales_ShoppingCartItem { get; set; } // ShoppingCartItem
        public IDbSet<Sales_SpecialOffer> Sales_SpecialOffer { get; set; } // SpecialOffer
        public IDbSet<Sales_SpecialOfferProduct> Sales_SpecialOfferProduct { get; set; } // SpecialOfferProduct
        public IDbSet<Sales_Store> Sales_Store { get; set; } // Store
        public IDbSet<Sales_VIndividualCustomer> Sales_VIndividualCustomer { get; set; } // vIndividualCustomer
        public IDbSet<Sales_VPersonDemographic> Sales_VPersonDemographic { get; set; } // vPersonDemographics
        public IDbSet<Sales_VSalesPerson> Sales_VSalesPerson { get; set; } // vSalesPerson
        public IDbSet<Sales_VSalesPersonSalesByFiscalYear> Sales_VSalesPersonSalesByFiscalYear { get; set; } // vSalesPersonSalesByFiscalYears
        public IDbSet<Sales_VStoreWithAddress> Sales_VStoreWithAddress { get; set; } // vStoreWithAddresses
        public IDbSet<Sales_VStoreWithContact> Sales_VStoreWithContact { get; set; } // vStoreWithContacts
        public IDbSet<Sales_VStoreWithDemographic> Sales_VStoreWithDemographic { get; set; } // vStoreWithDemographics
        public IDbSet<Sysdiagram> Sysdiagrams { get; set; } // sysdiagrams
        
        static AdventureWorksContext()
        {
            Database.SetInitializer<AdventureWorksContext>(null);
        }

        public AdventureWorksContext()
            : base("Name=AdventureWorksContext")
        {
        }

        public AdventureWorksContext(string connectionString) : base(connectionString)
        {
        }

        public AdventureWorksContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AwBuildVersionConfiguration());
            modelBuilder.Configurations.Add(new DatabaseLogConfiguration());
            modelBuilder.Configurations.Add(new ErrorLogConfiguration());
            modelBuilder.Configurations.Add(new HumanResources_DepartmentConfiguration());
            modelBuilder.Configurations.Add(new HumanResources_EmployeeConfiguration());
            modelBuilder.Configurations.Add(new HumanResources_EmployeeDepartmentHistoryConfiguration());
            modelBuilder.Configurations.Add(new HumanResources_EmployeePayHistoryConfiguration());
            modelBuilder.Configurations.Add(new HumanResources_JobCandidateConfiguration());
            modelBuilder.Configurations.Add(new HumanResources_ShiftConfiguration());
            modelBuilder.Configurations.Add(new HumanResources_VEmployeeConfiguration());
            modelBuilder.Configurations.Add(new HumanResources_VEmployeeDepartmentConfiguration());
            modelBuilder.Configurations.Add(new HumanResources_VEmployeeDepartmentHistoryConfiguration());
            modelBuilder.Configurations.Add(new HumanResources_VJobCandidateConfiguration());
            modelBuilder.Configurations.Add(new HumanResources_VJobCandidateEducationConfiguration());
            modelBuilder.Configurations.Add(new HumanResources_VJobCandidateEmploymentConfiguration());
            modelBuilder.Configurations.Add(new Person_AddressConfiguration());
            modelBuilder.Configurations.Add(new Person_AddressTypeConfiguration());
            modelBuilder.Configurations.Add(new Person_BusinessEntityConfiguration());
            modelBuilder.Configurations.Add(new Person_BusinessEntityAddressConfiguration());
            modelBuilder.Configurations.Add(new Person_BusinessEntityContactConfiguration());
            modelBuilder.Configurations.Add(new Person_ContactTypeConfiguration());
            modelBuilder.Configurations.Add(new Person_CountryRegionConfiguration());
            modelBuilder.Configurations.Add(new Person_EmailAddressConfiguration());
            modelBuilder.Configurations.Add(new Person_PasswordConfiguration());
            modelBuilder.Configurations.Add(new Person_PersonConfiguration());
            modelBuilder.Configurations.Add(new Person_PersonPhoneConfiguration());
            modelBuilder.Configurations.Add(new Person_PhoneNumberTypeConfiguration());
            modelBuilder.Configurations.Add(new Person_StateProvinceConfiguration());
            modelBuilder.Configurations.Add(new Person_VAdditionalContactInfoConfiguration());
            modelBuilder.Configurations.Add(new Person_VStateProvinceCountryRegionConfiguration());
            modelBuilder.Configurations.Add(new Production_BillOfMaterialConfiguration());
            modelBuilder.Configurations.Add(new Production_CultureConfiguration());
            modelBuilder.Configurations.Add(new Production_DocumentConfiguration());
            modelBuilder.Configurations.Add(new Production_IllustrationConfiguration());
            modelBuilder.Configurations.Add(new Production_LocationConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductCategoryConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductCostHistoryConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductDescriptionConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductDocumentConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductInventoryConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductListPriceHistoryConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductModelConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductModelIllustrationConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductModelProductDescriptionCultureConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductPhotoConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductProductPhotoConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductReviewConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductSubcategoryConfiguration());
            modelBuilder.Configurations.Add(new Production_ScrapReasonConfiguration());
            modelBuilder.Configurations.Add(new Production_TransactionHistoryConfiguration());
            modelBuilder.Configurations.Add(new Production_TransactionHistoryArchiveConfiguration());
            modelBuilder.Configurations.Add(new Production_UnitMeasureConfiguration());
            modelBuilder.Configurations.Add(new Production_VProductAndDescriptionConfiguration());
            modelBuilder.Configurations.Add(new Production_VProductModelCatalogDescriptionConfiguration());
            modelBuilder.Configurations.Add(new Production_VProductModelInstructionConfiguration());
            modelBuilder.Configurations.Add(new Production_WorkOrderConfiguration());
            modelBuilder.Configurations.Add(new Production_WorkOrderRoutingConfiguration());
            modelBuilder.Configurations.Add(new Purchasing_ProductVendorConfiguration());
            modelBuilder.Configurations.Add(new Purchasing_PurchaseOrderDetailConfiguration());
            modelBuilder.Configurations.Add(new Purchasing_PurchaseOrderHeaderConfiguration());
            modelBuilder.Configurations.Add(new Purchasing_ShipMethodConfiguration());
            modelBuilder.Configurations.Add(new Purchasing_VendorConfiguration());
            modelBuilder.Configurations.Add(new Purchasing_VVendorWithAddressConfiguration());
            modelBuilder.Configurations.Add(new Purchasing_VVendorWithContactConfiguration());
            modelBuilder.Configurations.Add(new Sales_CountryRegionCurrencyConfiguration());
            modelBuilder.Configurations.Add(new Sales_CreditCardConfiguration());
            modelBuilder.Configurations.Add(new Sales_CurrencyConfiguration());
            modelBuilder.Configurations.Add(new Sales_CurrencyRateConfiguration());
            modelBuilder.Configurations.Add(new Sales_CustomerConfiguration());
            modelBuilder.Configurations.Add(new Sales_PersonCreditCardConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesOrderDetailConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesOrderHeaderConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesOrderHeaderSalesReasonConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesPersonConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesPersonQuotaHistoryConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesReasonConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesTaxRateConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesTerritoryConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesTerritoryHistoryConfiguration());
            modelBuilder.Configurations.Add(new Sales_ShoppingCartItemConfiguration());
            modelBuilder.Configurations.Add(new Sales_SpecialOfferConfiguration());
            modelBuilder.Configurations.Add(new Sales_SpecialOfferProductConfiguration());
            modelBuilder.Configurations.Add(new Sales_StoreConfiguration());
            modelBuilder.Configurations.Add(new Sales_VIndividualCustomerConfiguration());
            modelBuilder.Configurations.Add(new Sales_VPersonDemographicConfiguration());
            modelBuilder.Configurations.Add(new Sales_VSalesPersonConfiguration());
            modelBuilder.Configurations.Add(new Sales_VSalesPersonSalesByFiscalYearConfiguration());
            modelBuilder.Configurations.Add(new Sales_VStoreWithAddressConfiguration());
            modelBuilder.Configurations.Add(new Sales_VStoreWithContactConfiguration());
            modelBuilder.Configurations.Add(new Sales_VStoreWithDemographicConfiguration());
            modelBuilder.Configurations.Add(new SysdiagramConfiguration());
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new AwBuildVersionConfiguration(schema));
            modelBuilder.Configurations.Add(new DatabaseLogConfiguration(schema));
            modelBuilder.Configurations.Add(new ErrorLogConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResources_DepartmentConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResources_EmployeeConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResources_EmployeeDepartmentHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResources_EmployeePayHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResources_JobCandidateConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResources_ShiftConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResources_VEmployeeConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResources_VEmployeeDepartmentConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResources_VEmployeeDepartmentHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResources_VJobCandidateConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResources_VJobCandidateEducationConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResources_VJobCandidateEmploymentConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_AddressConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_AddressTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_BusinessEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_BusinessEntityAddressConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_BusinessEntityContactConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_ContactTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_CountryRegionConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_EmailAddressConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_PasswordConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_PersonConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_PersonPhoneConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_PhoneNumberTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_StateProvinceConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_VAdditionalContactInfoConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_VStateProvinceCountryRegionConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_BillOfMaterialConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_CultureConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_DocumentConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_IllustrationConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_LocationConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductCategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductCostHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductDescriptionConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductDocumentConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductInventoryConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductListPriceHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductModelConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductModelIllustrationConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductModelProductDescriptionCultureConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductPhotoConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductProductPhotoConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductReviewConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductSubcategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ScrapReasonConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_TransactionHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_TransactionHistoryArchiveConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_UnitMeasureConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_VProductAndDescriptionConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_VProductModelCatalogDescriptionConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_VProductModelInstructionConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_WorkOrderConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_WorkOrderRoutingConfiguration(schema));
            modelBuilder.Configurations.Add(new Purchasing_ProductVendorConfiguration(schema));
            modelBuilder.Configurations.Add(new Purchasing_PurchaseOrderDetailConfiguration(schema));
            modelBuilder.Configurations.Add(new Purchasing_PurchaseOrderHeaderConfiguration(schema));
            modelBuilder.Configurations.Add(new Purchasing_ShipMethodConfiguration(schema));
            modelBuilder.Configurations.Add(new Purchasing_VendorConfiguration(schema));
            modelBuilder.Configurations.Add(new Purchasing_VVendorWithAddressConfiguration(schema));
            modelBuilder.Configurations.Add(new Purchasing_VVendorWithContactConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_CountryRegionCurrencyConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_CreditCardConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_CurrencyConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_CurrencyRateConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_CustomerConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_PersonCreditCardConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_SalesOrderDetailConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_SalesOrderHeaderConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_SalesOrderHeaderSalesReasonConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_SalesPersonConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_SalesPersonQuotaHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_SalesReasonConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_SalesTaxRateConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_SalesTerritoryConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_SalesTerritoryHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_ShoppingCartItemConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_SpecialOfferConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_SpecialOfferProductConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_StoreConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_VIndividualCustomerConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_VPersonDemographicConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_VSalesPersonConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_VSalesPersonSalesByFiscalYearConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_VStoreWithAddressConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_VStoreWithContactConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_VStoreWithDemographicConfiguration(schema));
            modelBuilder.Configurations.Add(new SysdiagramConfiguration(schema));
            return modelBuilder;
        }
        
        // Stored Procedures
        public List<UspGetBillOfMaterialsReturnModel> UspGetBillOfMaterials(int? startProductId, DateTime? checkDate, out int procResult)
        {
            var startProductIdParam = new SqlParameter { ParameterName = "@StartProductID", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = startProductId.GetValueOrDefault() };
            var checkDateParam = new SqlParameter { ParameterName = "@CheckDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = checkDate.GetValueOrDefault() };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<UspGetBillOfMaterialsReturnModel>("EXEC @procResult = [dbo].[uspGetBillOfMaterials] @StartProductID, @CheckDate", startProductIdParam, checkDateParam, procResultParam).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public List<UspGetEmployeeManagersReturnModel> UspGetEmployeeManagers(int? businessEntityId, out int procResult)
        {
            var businessEntityIdParam = new SqlParameter { ParameterName = "@BusinessEntityID", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = businessEntityId.GetValueOrDefault() };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<UspGetEmployeeManagersReturnModel>("EXEC @procResult = [dbo].[uspGetEmployeeManagers] @BusinessEntityID", businessEntityIdParam, procResultParam).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public List<UspGetManagerEmployeesReturnModel> UspGetManagerEmployees(int? businessEntityId, out int procResult)
        {
            var businessEntityIdParam = new SqlParameter { ParameterName = "@BusinessEntityID", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = businessEntityId.GetValueOrDefault() };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<UspGetManagerEmployeesReturnModel>("EXEC @procResult = [dbo].[uspGetManagerEmployees] @BusinessEntityID", businessEntityIdParam, procResultParam).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public List<UspGetWhereUsedProductIdReturnModel> UspGetWhereUsedProductId(int? startProductId, DateTime? checkDate, out int procResult)
        {
            var startProductIdParam = new SqlParameter { ParameterName = "@StartProductID", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = startProductId.GetValueOrDefault() };
            var checkDateParam = new SqlParameter { ParameterName = "@CheckDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = checkDate.GetValueOrDefault() };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<UspGetWhereUsedProductIdReturnModel>("EXEC @procResult = [dbo].[uspGetWhereUsedProductID] @StartProductID, @CheckDate", startProductIdParam, checkDateParam, procResultParam).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public int UspLogError(out int? errorLogId)
        {
            var errorLogIdParam = new SqlParameter { ParameterName = "@ErrorLogID", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[uspLogError] @ErrorLogID OUTPUT", errorLogIdParam, procResultParam);
            errorLogId = (int) errorLogIdParam.Value;
 
            return (int) procResultParam.Value;
        }

        public int UspPrintError()
        {
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[uspPrintError] ", procResultParam);
 
            return (int) procResultParam.Value;
        }

        public int UspSearchCandidateResumes(string searchString, bool? useInflectional, bool? useThesaurus, int? language)
        {
            var searchStringParam = new SqlParameter { ParameterName = "@searchString", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = searchString, Size = 1000 };
            var useInflectionalParam = new SqlParameter { ParameterName = "@useInflectional", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Input, Value = useInflectional.GetValueOrDefault() };
            var useThesaurusParam = new SqlParameter { ParameterName = "@useThesaurus", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Input, Value = useThesaurus.GetValueOrDefault() };
            var languageParam = new SqlParameter { ParameterName = "@language", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = language.GetValueOrDefault() };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[uspSearchCandidateResumes] @searchString, @useInflectional, @useThesaurus, @language", searchStringParam, useInflectionalParam, useThesaurusParam, languageParam, procResultParam);
 
            return (int) procResultParam.Value;
        }

        public int HumanResources_UspUpdateEmployeeHireInfo(int? businessEntityId, string jobTitle, DateTime? hireDate, DateTime? rateChangeDate, decimal? rate, byte? payFrequency, bool? currentFlag)
        {
            var businessEntityIdParam = new SqlParameter { ParameterName = "@BusinessEntityID", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = businessEntityId.GetValueOrDefault() };
            var jobTitleParam = new SqlParameter { ParameterName = "@JobTitle", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = jobTitle, Size = 50 };
            var hireDateParam = new SqlParameter { ParameterName = "@HireDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = hireDate.GetValueOrDefault() };
            var rateChangeDateParam = new SqlParameter { ParameterName = "@RateChangeDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = rateChangeDate.GetValueOrDefault() };
            var rateParam = new SqlParameter { ParameterName = "@Rate", SqlDbType = SqlDbType.Money, Direction = ParameterDirection.Input, Value = rate.GetValueOrDefault() };
            var payFrequencyParam = new SqlParameter { ParameterName = "@PayFrequency", SqlDbType = SqlDbType.TinyInt, Direction = ParameterDirection.Input, Value = payFrequency.GetValueOrDefault() };
            var currentFlagParam = new SqlParameter { ParameterName = "@CurrentFlag", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Input, Value = currentFlag.GetValueOrDefault() };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = [HumanResources].[uspUpdateEmployeeHireInfo] @BusinessEntityID, @JobTitle, @HireDate, @RateChangeDate, @Rate, @PayFrequency, @CurrentFlag", businessEntityIdParam, jobTitleParam, hireDateParam, rateChangeDateParam, rateParam, payFrequencyParam, currentFlagParam, procResultParam);
 
            return (int) procResultParam.Value;
        }

        public int HumanResources_UspUpdateEmployeeLogin(int? businessEntityId, string organizationNode, string loginId, string jobTitle, DateTime? hireDate, bool? currentFlag)
        {
            var businessEntityIdParam = new SqlParameter { ParameterName = "@BusinessEntityID", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = businessEntityId.GetValueOrDefault() };
            var organizationNodeParam = new SqlParameter { ParameterName = "@OrganizationNode", SqlDbType = SqlDbType.VarChar, Direction = ParameterDirection.Input, Value = organizationNode, Size = 892 };
            var loginIdParam = new SqlParameter { ParameterName = "@LoginID", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = loginId, Size = 256 };
            var jobTitleParam = new SqlParameter { ParameterName = "@JobTitle", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = jobTitle, Size = 50 };
            var hireDateParam = new SqlParameter { ParameterName = "@HireDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = hireDate.GetValueOrDefault() };
            var currentFlagParam = new SqlParameter { ParameterName = "@CurrentFlag", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Input, Value = currentFlag.GetValueOrDefault() };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = [HumanResources].[uspUpdateEmployeeLogin] @BusinessEntityID, @OrganizationNode, @LoginID, @JobTitle, @HireDate, @CurrentFlag", businessEntityIdParam, organizationNodeParam, loginIdParam, jobTitleParam, hireDateParam, currentFlagParam, procResultParam);
 
            return (int) procResultParam.Value;
        }

        public int HumanResources_UspUpdateEmployeePersonalInfo(int? businessEntityId, string nationalIdNumber, DateTime? birthDate, string maritalStatus, string gender)
        {
            var businessEntityIdParam = new SqlParameter { ParameterName = "@BusinessEntityID", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = businessEntityId.GetValueOrDefault() };
            var nationalIdNumberParam = new SqlParameter { ParameterName = "@NationalIDNumber", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = nationalIdNumber, Size = 15 };
            var birthDateParam = new SqlParameter { ParameterName = "@BirthDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = birthDate.GetValueOrDefault() };
            var maritalStatusParam = new SqlParameter { ParameterName = "@MaritalStatus", SqlDbType = SqlDbType.NChar, Direction = ParameterDirection.Input, Value = maritalStatus, Size = 1 };
            var genderParam = new SqlParameter { ParameterName = "@Gender", SqlDbType = SqlDbType.NChar, Direction = ParameterDirection.Input, Value = gender, Size = 1 };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = [HumanResources].[uspUpdateEmployeePersonalInfo] @BusinessEntityID, @NationalIDNumber, @BirthDate, @MaritalStatus, @Gender", businessEntityIdParam, nationalIdNumberParam, birthDateParam, maritalStatusParam, genderParam, procResultParam);
 
            return (int) procResultParam.Value;
        }

    }
}
