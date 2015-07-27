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
    // Document
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.13.0.0")]
    public class Production_Document
    {
        public string DocumentNode { get; set; } // DocumentNode (Primary key). Primary key for Document records.
        public short? DocumentLevel { get; set; } // DocumentLevel. Depth in the document hierarchy.
        public string Title { get; set; } // Title. Title of the document.
        public int Owner { get; set; } // Owner. Employee who controls the document.  Foreign key to Employee.BusinessEntityID
        public bool FolderFlag { get; set; } // FolderFlag. 0 = This is a folder, 1 = This is a document.
        public string FileName { get; set; } // FileName. File name of the document
        public string FileExtension { get; set; } // FileExtension. File extension indicating the document type. For example, .doc or .txt.
        public string Revision { get; set; } // Revision. Revision number of the document.
        public int ChangeNumber { get; set; } // ChangeNumber. Engineering change approval number.
        public byte Status { get; set; } // Status. 1 = Pending approval, 2 = Approved, 3 = Obsolete
        public string DocumentSummary { get; set; } // DocumentSummary. Document abstract.
        public byte[] Document { get; set; } // Document. Complete document.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Required for FileStream.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Production_ProductDocument> Production_ProductDocument { get; set; } // Many to many mapping

        // Foreign keys
        public virtual HumanResources_Employee HumanResources_Employee { get; set; } // FK_Document_Employee_Owner
        
        public Production_Document()
        {
            FolderFlag = false;
            ChangeNumber = 0;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Production_ProductDocument = new List<Production_ProductDocument>();
        }
    }

}
