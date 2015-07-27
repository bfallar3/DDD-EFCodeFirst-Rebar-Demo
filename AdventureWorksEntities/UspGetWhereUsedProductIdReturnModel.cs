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
    public class UspGetWhereUsedProductIdReturnModel
    {
        public Int32? ProductAssemblyID { get; set; }
        public Int32? ComponentID { get; set; }
        public String ComponentDesc { get; set; }
        public Decimal? TotalQuantity { get; set; }
        public Decimal? StandardCost { get; set; }
        public Decimal? ListPrice { get; set; }
        public Int16? BOMLevel { get; set; }
        public Int32? RecursionLevel { get; set; }
    }

}
