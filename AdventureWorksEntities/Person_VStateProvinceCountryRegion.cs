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
    // vStateProvinceCountryRegion
    public class Person_VStateProvinceCountryRegion
    {
        public int StateProvinceId { get; set; } // StateProvinceID
        public string StateProvinceCode { get; set; } // StateProvinceCode
        public bool IsOnlyStateProvinceFlag { get; set; } // IsOnlyStateProvinceFlag
        public string StateProvinceName { get; set; } // StateProvinceName
        public int TerritoryId { get; set; } // TerritoryID
        public string CountryRegionCode { get; set; } // CountryRegionCode
        public string CountryRegionName { get; set; } // CountryRegionName
    }

}
