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
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.13.0.0")]
    public class FakeAdventureWorksContext : IAdventureWorksContext
    {
        public IDbSet<AwBuildVersion> AwBuildVersions { get; set; }
        public IDbSet<DatabaseLog> DatabaseLogs { get; set; }
        public IDbSet<ErrorLog> ErrorLogs { get; set; }
        public IDbSet<HumanResources_Department> HumanResources_Department { get; set; }
        public IDbSet<HumanResources_Employee> HumanResources_Employee { get; set; }
        public IDbSet<HumanResources_EmployeeDepartmentHistory> HumanResources_EmployeeDepartmentHistory { get; set; }
        public IDbSet<HumanResources_EmployeePayHistory> HumanResources_EmployeePayHistory { get; set; }
        public IDbSet<HumanResources_JobCandidate> HumanResources_JobCandidate { get; set; }
        public IDbSet<HumanResources_Shift> HumanResources_Shift { get; set; }
        public IDbSet<HumanResources_VEmployee> HumanResources_VEmployee { get; set; }
        public IDbSet<HumanResources_VEmployeeDepartment> HumanResources_VEmployeeDepartment { get; set; }
        public IDbSet<HumanResources_VEmployeeDepartmentHistory> HumanResources_VEmployeeDepartmentHistory { get; set; }
        public IDbSet<HumanResources_VJobCandidate> HumanResources_VJobCandidate { get; set; }
        public IDbSet<HumanResources_VJobCandidateEducation> HumanResources_VJobCandidateEducation { get; set; }
        public IDbSet<HumanResources_VJobCandidateEmployment> HumanResources_VJobCandidateEmployment { get; set; }
        public IDbSet<Person_Address> Person_Address { get; set; }
        public IDbSet<Person_AddressType> Person_AddressType { get; set; }
        public IDbSet<Person_BusinessEntity> Person_BusinessEntity { get; set; }
        public IDbSet<Person_BusinessEntityAddress> Person_BusinessEntityAddress { get; set; }
        public IDbSet<Person_BusinessEntityContact> Person_BusinessEntityContact { get; set; }
        public IDbSet<Person_ContactType> Person_ContactType { get; set; }
        public IDbSet<Person_CountryRegion> Person_CountryRegion { get; set; }
        public IDbSet<Person_EmailAddress> Person_EmailAddress { get; set; }
        public IDbSet<Person_Password> Person_Password { get; set; }
        public IDbSet<Person_Person> Person_Person { get; set; }
        public IDbSet<Person_PersonPhone> Person_PersonPhone { get; set; }
        public IDbSet<Person_PhoneNumberType> Person_PhoneNumberType { get; set; }
        public IDbSet<Person_StateProvince> Person_StateProvince { get; set; }
        public IDbSet<Person_VAdditionalContactInfo> Person_VAdditionalContactInfo { get; set; }
        public IDbSet<Person_VStateProvinceCountryRegion> Person_VStateProvinceCountryRegion { get; set; }
        public IDbSet<Production_BillOfMaterial> Production_BillOfMaterial { get; set; }
        public IDbSet<Production_Culture> Production_Culture { get; set; }
        public IDbSet<Production_Document> Production_Document { get; set; }
        public IDbSet<Production_Illustration> Production_Illustration { get; set; }
        public IDbSet<Production_Location> Production_Location { get; set; }
        public IDbSet<Production_Product> Production_Product { get; set; }
        public IDbSet<Production_ProductCategory> Production_ProductCategory { get; set; }
        public IDbSet<Production_ProductCostHistory> Production_ProductCostHistory { get; set; }
        public IDbSet<Production_ProductDescription> Production_ProductDescription { get; set; }
        public IDbSet<Production_ProductDocument> Production_ProductDocument { get; set; }
        public IDbSet<Production_ProductInventory> Production_ProductInventory { get; set; }
        public IDbSet<Production_ProductListPriceHistory> Production_ProductListPriceHistory { get; set; }
        public IDbSet<Production_ProductModel> Production_ProductModel { get; set; }
        public IDbSet<Production_ProductModelIllustration> Production_ProductModelIllustration { get; set; }
        public IDbSet<Production_ProductModelProductDescriptionCulture> Production_ProductModelProductDescriptionCulture { get; set; }
        public IDbSet<Production_ProductPhoto> Production_ProductPhoto { get; set; }
        public IDbSet<Production_ProductProductPhoto> Production_ProductProductPhoto { get; set; }
        public IDbSet<Production_ProductReview> Production_ProductReview { get; set; }
        public IDbSet<Production_ProductSubcategory> Production_ProductSubcategory { get; set; }
        public IDbSet<Production_ScrapReason> Production_ScrapReason { get; set; }
        public IDbSet<Production_TransactionHistory> Production_TransactionHistory { get; set; }
        public IDbSet<Production_TransactionHistoryArchive> Production_TransactionHistoryArchive { get; set; }
        public IDbSet<Production_UnitMeasure> Production_UnitMeasure { get; set; }
        public IDbSet<Production_VProductAndDescription> Production_VProductAndDescription { get; set; }
        public IDbSet<Production_VProductModelCatalogDescription> Production_VProductModelCatalogDescription { get; set; }
        public IDbSet<Production_VProductModelInstruction> Production_VProductModelInstruction { get; set; }
        public IDbSet<Production_WorkOrder> Production_WorkOrder { get; set; }
        public IDbSet<Production_WorkOrderRouting> Production_WorkOrderRouting { get; set; }
        public IDbSet<Purchasing_ProductVendor> Purchasing_ProductVendor { get; set; }
        public IDbSet<Purchasing_PurchaseOrderDetail> Purchasing_PurchaseOrderDetail { get; set; }
        public IDbSet<Purchasing_PurchaseOrderHeader> Purchasing_PurchaseOrderHeader { get; set; }
        public IDbSet<Purchasing_ShipMethod> Purchasing_ShipMethod { get; set; }
        public IDbSet<Purchasing_Vendor> Purchasing_Vendor { get; set; }
        public IDbSet<Purchasing_VVendorWithAddress> Purchasing_VVendorWithAddress { get; set; }
        public IDbSet<Purchasing_VVendorWithContact> Purchasing_VVendorWithContact { get; set; }
        public IDbSet<Sales_CountryRegionCurrency> Sales_CountryRegionCurrency { get; set; }
        public IDbSet<Sales_CreditCard> Sales_CreditCard { get; set; }
        public IDbSet<Sales_Currency> Sales_Currency { get; set; }
        public IDbSet<Sales_CurrencyRate> Sales_CurrencyRate { get; set; }
        public IDbSet<Sales_Customer> Sales_Customer { get; set; }
        public IDbSet<Sales_PersonCreditCard> Sales_PersonCreditCard { get; set; }
        public IDbSet<Sales_SalesOrderDetail> Sales_SalesOrderDetail { get; set; }
        public IDbSet<Sales_SalesOrderHeader> Sales_SalesOrderHeader { get; set; }
        public IDbSet<Sales_SalesOrderHeaderSalesReason> Sales_SalesOrderHeaderSalesReason { get; set; }
        public IDbSet<Sales_SalesPerson> Sales_SalesPerson { get; set; }
        public IDbSet<Sales_SalesPersonQuotaHistory> Sales_SalesPersonQuotaHistory { get; set; }
        public IDbSet<Sales_SalesReason> Sales_SalesReason { get; set; }
        public IDbSet<Sales_SalesTaxRate> Sales_SalesTaxRate { get; set; }
        public IDbSet<Sales_SalesTerritory> Sales_SalesTerritory { get; set; }
        public IDbSet<Sales_SalesTerritoryHistory> Sales_SalesTerritoryHistory { get; set; }
        public IDbSet<Sales_ShoppingCartItem> Sales_ShoppingCartItem { get; set; }
        public IDbSet<Sales_SpecialOffer> Sales_SpecialOffer { get; set; }
        public IDbSet<Sales_SpecialOfferProduct> Sales_SpecialOfferProduct { get; set; }
        public IDbSet<Sales_Store> Sales_Store { get; set; }
        public IDbSet<Sales_VIndividualCustomer> Sales_VIndividualCustomer { get; set; }
        public IDbSet<Sales_VPersonDemographic> Sales_VPersonDemographic { get; set; }
        public IDbSet<Sales_VSalesPerson> Sales_VSalesPerson { get; set; }
        public IDbSet<Sales_VSalesPersonSalesByFiscalYear> Sales_VSalesPersonSalesByFiscalYear { get; set; }
        public IDbSet<Sales_VStoreWithAddress> Sales_VStoreWithAddress { get; set; }
        public IDbSet<Sales_VStoreWithContact> Sales_VStoreWithContact { get; set; }
        public IDbSet<Sales_VStoreWithDemographic> Sales_VStoreWithDemographic { get; set; }
        public IDbSet<Sysdiagram> Sysdiagrams { get; set; }

        public FakeAdventureWorksContext()
        {
            AwBuildVersions = new FakeDbSet<AwBuildVersion>();
            DatabaseLogs = new FakeDbSet<DatabaseLog>();
            ErrorLogs = new FakeDbSet<ErrorLog>();
            HumanResources_Department = new FakeDbSet<HumanResources_Department>();
            HumanResources_Employee = new FakeDbSet<HumanResources_Employee>();
            HumanResources_EmployeeDepartmentHistory = new FakeDbSet<HumanResources_EmployeeDepartmentHistory>();
            HumanResources_EmployeePayHistory = new FakeDbSet<HumanResources_EmployeePayHistory>();
            HumanResources_JobCandidate = new FakeDbSet<HumanResources_JobCandidate>();
            HumanResources_Shift = new FakeDbSet<HumanResources_Shift>();
            HumanResources_VEmployee = new FakeDbSet<HumanResources_VEmployee>();
            HumanResources_VEmployeeDepartment = new FakeDbSet<HumanResources_VEmployeeDepartment>();
            HumanResources_VEmployeeDepartmentHistory = new FakeDbSet<HumanResources_VEmployeeDepartmentHistory>();
            HumanResources_VJobCandidate = new FakeDbSet<HumanResources_VJobCandidate>();
            HumanResources_VJobCandidateEducation = new FakeDbSet<HumanResources_VJobCandidateEducation>();
            HumanResources_VJobCandidateEmployment = new FakeDbSet<HumanResources_VJobCandidateEmployment>();
            Person_Address = new FakeDbSet<Person_Address>();
            Person_AddressType = new FakeDbSet<Person_AddressType>();
            Person_BusinessEntity = new FakeDbSet<Person_BusinessEntity>();
            Person_BusinessEntityAddress = new FakeDbSet<Person_BusinessEntityAddress>();
            Person_BusinessEntityContact = new FakeDbSet<Person_BusinessEntityContact>();
            Person_ContactType = new FakeDbSet<Person_ContactType>();
            Person_CountryRegion = new FakeDbSet<Person_CountryRegion>();
            Person_EmailAddress = new FakeDbSet<Person_EmailAddress>();
            Person_Password = new FakeDbSet<Person_Password>();
            Person_Person = new FakeDbSet<Person_Person>();
            Person_PersonPhone = new FakeDbSet<Person_PersonPhone>();
            Person_PhoneNumberType = new FakeDbSet<Person_PhoneNumberType>();
            Person_StateProvince = new FakeDbSet<Person_StateProvince>();
            Person_VAdditionalContactInfo = new FakeDbSet<Person_VAdditionalContactInfo>();
            Person_VStateProvinceCountryRegion = new FakeDbSet<Person_VStateProvinceCountryRegion>();
            Production_BillOfMaterial = new FakeDbSet<Production_BillOfMaterial>();
            Production_Culture = new FakeDbSet<Production_Culture>();
            Production_Document = new FakeDbSet<Production_Document>();
            Production_Illustration = new FakeDbSet<Production_Illustration>();
            Production_Location = new FakeDbSet<Production_Location>();
            Production_Product = new FakeDbSet<Production_Product>();
            Production_ProductCategory = new FakeDbSet<Production_ProductCategory>();
            Production_ProductCostHistory = new FakeDbSet<Production_ProductCostHistory>();
            Production_ProductDescription = new FakeDbSet<Production_ProductDescription>();
            Production_ProductDocument = new FakeDbSet<Production_ProductDocument>();
            Production_ProductInventory = new FakeDbSet<Production_ProductInventory>();
            Production_ProductListPriceHistory = new FakeDbSet<Production_ProductListPriceHistory>();
            Production_ProductModel = new FakeDbSet<Production_ProductModel>();
            Production_ProductModelIllustration = new FakeDbSet<Production_ProductModelIllustration>();
            Production_ProductModelProductDescriptionCulture = new FakeDbSet<Production_ProductModelProductDescriptionCulture>();
            Production_ProductPhoto = new FakeDbSet<Production_ProductPhoto>();
            Production_ProductProductPhoto = new FakeDbSet<Production_ProductProductPhoto>();
            Production_ProductReview = new FakeDbSet<Production_ProductReview>();
            Production_ProductSubcategory = new FakeDbSet<Production_ProductSubcategory>();
            Production_ScrapReason = new FakeDbSet<Production_ScrapReason>();
            Production_TransactionHistory = new FakeDbSet<Production_TransactionHistory>();
            Production_TransactionHistoryArchive = new FakeDbSet<Production_TransactionHistoryArchive>();
            Production_UnitMeasure = new FakeDbSet<Production_UnitMeasure>();
            Production_VProductAndDescription = new FakeDbSet<Production_VProductAndDescription>();
            Production_VProductModelCatalogDescription = new FakeDbSet<Production_VProductModelCatalogDescription>();
            Production_VProductModelInstruction = new FakeDbSet<Production_VProductModelInstruction>();
            Production_WorkOrder = new FakeDbSet<Production_WorkOrder>();
            Production_WorkOrderRouting = new FakeDbSet<Production_WorkOrderRouting>();
            Purchasing_ProductVendor = new FakeDbSet<Purchasing_ProductVendor>();
            Purchasing_PurchaseOrderDetail = new FakeDbSet<Purchasing_PurchaseOrderDetail>();
            Purchasing_PurchaseOrderHeader = new FakeDbSet<Purchasing_PurchaseOrderHeader>();
            Purchasing_ShipMethod = new FakeDbSet<Purchasing_ShipMethod>();
            Purchasing_Vendor = new FakeDbSet<Purchasing_Vendor>();
            Purchasing_VVendorWithAddress = new FakeDbSet<Purchasing_VVendorWithAddress>();
            Purchasing_VVendorWithContact = new FakeDbSet<Purchasing_VVendorWithContact>();
            Sales_CountryRegionCurrency = new FakeDbSet<Sales_CountryRegionCurrency>();
            Sales_CreditCard = new FakeDbSet<Sales_CreditCard>();
            Sales_Currency = new FakeDbSet<Sales_Currency>();
            Sales_CurrencyRate = new FakeDbSet<Sales_CurrencyRate>();
            Sales_Customer = new FakeDbSet<Sales_Customer>();
            Sales_PersonCreditCard = new FakeDbSet<Sales_PersonCreditCard>();
            Sales_SalesOrderDetail = new FakeDbSet<Sales_SalesOrderDetail>();
            Sales_SalesOrderHeader = new FakeDbSet<Sales_SalesOrderHeader>();
            Sales_SalesOrderHeaderSalesReason = new FakeDbSet<Sales_SalesOrderHeaderSalesReason>();
            Sales_SalesPerson = new FakeDbSet<Sales_SalesPerson>();
            Sales_SalesPersonQuotaHistory = new FakeDbSet<Sales_SalesPersonQuotaHistory>();
            Sales_SalesReason = new FakeDbSet<Sales_SalesReason>();
            Sales_SalesTaxRate = new FakeDbSet<Sales_SalesTaxRate>();
            Sales_SalesTerritory = new FakeDbSet<Sales_SalesTerritory>();
            Sales_SalesTerritoryHistory = new FakeDbSet<Sales_SalesTerritoryHistory>();
            Sales_ShoppingCartItem = new FakeDbSet<Sales_ShoppingCartItem>();
            Sales_SpecialOffer = new FakeDbSet<Sales_SpecialOffer>();
            Sales_SpecialOfferProduct = new FakeDbSet<Sales_SpecialOfferProduct>();
            Sales_Store = new FakeDbSet<Sales_Store>();
            Sales_VIndividualCustomer = new FakeDbSet<Sales_VIndividualCustomer>();
            Sales_VPersonDemographic = new FakeDbSet<Sales_VPersonDemographic>();
            Sales_VSalesPerson = new FakeDbSet<Sales_VSalesPerson>();
            Sales_VSalesPersonSalesByFiscalYear = new FakeDbSet<Sales_VSalesPersonSalesByFiscalYear>();
            Sales_VStoreWithAddress = new FakeDbSet<Sales_VStoreWithAddress>();
            Sales_VStoreWithContact = new FakeDbSet<Sales_VStoreWithContact>();
            Sales_VStoreWithDemographic = new FakeDbSet<Sales_VStoreWithDemographic>();
            Sysdiagrams = new FakeDbSet<Sysdiagram>();
        }

        public int SaveChanges()
        {
            return 0;
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
        }
        
        public void Dispose()
        {
            Dispose(true);
        }
        
        // Stored Procedures
        public List<UspGetBillOfMaterialsReturnModel> UspGetBillOfMaterials(int? startProductId, DateTime? checkDate, out int procResult)
        {
 
            procResult = 0;
            return new List<UspGetBillOfMaterialsReturnModel>();
        }

        public List<UspGetEmployeeManagersReturnModel> UspGetEmployeeManagers(int? businessEntityId, out int procResult)
        {
 
            procResult = 0;
            return new List<UspGetEmployeeManagersReturnModel>();
        }

        public List<UspGetManagerEmployeesReturnModel> UspGetManagerEmployees(int? businessEntityId, out int procResult)
        {
 
            procResult = 0;
            return new List<UspGetManagerEmployeesReturnModel>();
        }

        public List<UspGetWhereUsedProductIdReturnModel> UspGetWhereUsedProductId(int? startProductId, DateTime? checkDate, out int procResult)
        {
 
            procResult = 0;
            return new List<UspGetWhereUsedProductIdReturnModel>();
        }

        public int UspLogError(out int? errorLogId)
        {
            errorLogId = default(int);
 
            return 0;
        }

        public int UspPrintError()
        {
 
            return 0;
        }

        public int UspSearchCandidateResumes(string searchString, bool? useInflectional, bool? useThesaurus, int? language)
        {
 
            return 0;
        }

        public int HumanResources_UspUpdateEmployeeHireInfo(int? businessEntityId, string jobTitle, DateTime? hireDate, DateTime? rateChangeDate, decimal? rate, byte? payFrequency, bool? currentFlag)
        {
 
            return 0;
        }

        public int HumanResources_UspUpdateEmployeeLogin(int? businessEntityId, string organizationNode, string loginId, string jobTitle, DateTime? hireDate, bool? currentFlag)
        {
 
            return 0;
        }

        public int HumanResources_UspUpdateEmployeePersonalInfo(int? businessEntityId, string nationalIdNumber, DateTime? birthDate, string maritalStatus, string gender)
        {
 
            return 0;
        }

    }
}
