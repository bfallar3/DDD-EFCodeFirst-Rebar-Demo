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
    // Person
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.13.0.0")]
    public class Person_Person
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key for Person records.
        public string PersonType { get; set; } // PersonType. Primary type of person: SC = Store Contact, IN = Individual (retail) customer, SP = Sales person, EM = Employee (non-sales), VC = Vendor contact, GC = General contact
        public bool NameStyle { get; set; } // NameStyle. 0 = The data in FirstName and LastName are stored in western style (first name, last name) order.  1 = Eastern style (last name, first name) order.
        public string Title { get; set; } // Title. A courtesy title. For example, Mr. or Ms.
        public string FirstName { get; set; } // FirstName. First name of the person.
        public string MiddleName { get; set; } // MiddleName. Middle name or middle initial of the person.
        public string LastName { get; set; } // LastName. Last name of the person.
        public string Suffix { get; set; } // Suffix. Surname suffix. For example, Sr. or Jr.
        public int EmailPromotion { get; set; } // EmailPromotion. 0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorks, 2 = Contact does wish to receive e-mail promotions from AdventureWorks and selected partners.
        public string AdditionalContactInfo { get; set; } // AdditionalContactInfo. Additional contact information about the person stored in xml format.
        public string Demographics { get; set; } // Demographics. Personal information such as hobbies, and income collected from online shoppers. Used for sales analysis.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual HumanResources_Employee HumanResources_Employee { get; set; } // Employee.FK_Employee_Person_BusinessEntityID
        public virtual ICollection<Person_BusinessEntityContact> Person_BusinessEntityContact { get; set; } // Many to many mapping
        public virtual ICollection<Person_EmailAddress> Person_EmailAddress { get; set; } // Many to many mapping
        public virtual ICollection<Person_PersonPhone> Person_PersonPhone { get; set; } // Many to many mapping
        public virtual ICollection<Sales_Customer> Sales_Customer { get; set; } // Customer.FK_Customer_Person_PersonID
        public virtual ICollection<Sales_PersonCreditCard> Sales_PersonCreditCard { get; set; } // Many to many mapping
        public virtual Person_Password Person_Password { get; set; } // Password.FK_Password_Person_BusinessEntityID

        // Foreign keys
        public virtual Person_BusinessEntity Person_BusinessEntity { get; set; } // FK_Person_BusinessEntity_BusinessEntityID
        
        public Person_Person()
        {
            NameStyle = false;
            EmailPromotion = 0;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Person_BusinessEntityContact = new List<Person_BusinessEntityContact>();
            Sales_Customer = new List<Sales_Customer>();
            Person_EmailAddress = new List<Person_EmailAddress>();
            Sales_PersonCreditCard = new List<Sales_PersonCreditCard>();
            Person_PersonPhone = new List<Person_PersonPhone>();
        }
    }

}
