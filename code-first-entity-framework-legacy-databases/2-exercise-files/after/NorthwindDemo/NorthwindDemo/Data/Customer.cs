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
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using CodeFirstStoreFunctions;
using System.Data.Entity.ModelConfiguration;
using System.Threading;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace NorthwindDemo.Data
{
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.15.2.0")]
    public partial class Customer
    {
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public virtual ICollection<CustomerDemographic> CustomerDemographics { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        
        public Customer()
        {
            Orders = new ObservableCollection<Order>();
            CustomerDemographics = new ObservableCollection<CustomerDemographic>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
