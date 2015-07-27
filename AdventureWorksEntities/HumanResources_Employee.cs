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
    // Employee
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.13.0.0")]
    public class HumanResources_Employee
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key for Employee records.  Foreign key to BusinessEntity.BusinessEntityID.
        public string NationalIdNumber { get; set; } // NationalIDNumber. Unique national identification number such as a social security number.
        public string LoginId { get; set; } // LoginID. Network login.
        public string OrganizationNode { get; set; } // OrganizationNode. Where the employee is located in corporate hierarchy.
        public short? OrganizationLevel { get; set; } // OrganizationLevel. The depth of the employee in the corporate hierarchy.
        public string JobTitle { get; set; } // JobTitle. Work title such as Buyer or Sales Representative.
        public DateTime BirthDate { get; set; } // BirthDate. Date of birth.
        public string MaritalStatus { get; set; } // MaritalStatus. M = Married, S = Single
        public string Gender { get; set; } // Gender. M = Male, F = Female
        public DateTime HireDate { get; set; } // HireDate. Employee hired on this date.
        public bool SalariedFlag { get; set; } // SalariedFlag. Job classification. 0 = Hourly, not exempt from collective bargaining. 1 = Salaried, exempt from collective bargaining.
        public short VacationHours { get; set; } // VacationHours. Number of available vacation hours.
        public short SickLeaveHours { get; set; } // SickLeaveHours. Number of available sick leave hours.
        public bool CurrentFlag { get; set; } // CurrentFlag. 0 = Inactive, 1 = Active
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.
        public string Test { get; set; } // Test

        // Reverse navigation
        public virtual ICollection<HumanResources_EmployeeDepartmentHistory> HumanResources_EmployeeDepartmentHistory { get; set; } // Many to many mapping
        public virtual ICollection<HumanResources_EmployeePayHistory> HumanResources_EmployeePayHistory { get; set; } // Many to many mapping
        public virtual ICollection<HumanResources_JobCandidate> HumanResources_JobCandidate { get; set; } // JobCandidate.FK_JobCandidate_Employee_BusinessEntityID
        public virtual ICollection<Production_Document> Production_Document { get; set; } // Document.FK_Document_Employee_Owner
        public virtual ICollection<Purchasing_PurchaseOrderHeader> Purchasing_PurchaseOrderHeader { get; set; } // PurchaseOrderHeader.FK_PurchaseOrderHeader_Employee_EmployeeID
        public virtual Sales_SalesPerson Sales_SalesPerson { get; set; } // SalesPerson.FK_SalesPerson_Employee_BusinessEntityID

        // Foreign keys
        public virtual Person_Person Person_Person { get; set; } // FK_Employee_Person_BusinessEntityID
        
        public HumanResources_Employee()
        {
            SalariedFlag = true;
            VacationHours = 0;
            SickLeaveHours = 0;
            CurrentFlag = true;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Production_Document = new List<Production_Document>();
            HumanResources_EmployeeDepartmentHistory = new List<HumanResources_EmployeeDepartmentHistory>();
            HumanResources_EmployeePayHistory = new List<HumanResources_EmployeePayHistory>();
            HumanResources_JobCandidate = new List<HumanResources_JobCandidate>();
            Purchasing_PurchaseOrderHeader = new List<Purchasing_PurchaseOrderHeader>();
        }
    }

}
