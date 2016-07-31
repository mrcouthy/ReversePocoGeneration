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
    public interface INorthwindDbContext : IDisposable, ISaveChangesCount
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<CustomerDemographic> CustomerDemographics { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Engineer> Engineers { get; set; }
        DbSet<EngineerOrder> EngineerOrders { get; set; }
        DbSet<EngineerOrderItem> EngineerOrderItems { get; set; }
        DbSet<GeographyType> GeographyTypes { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderDetail> OrderDetails { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Region> Regions { get; set; }
        DbSet<Shipper> Shippers { get; set; }
        DbSet<Supplier> Suppliers { get; set; }
        DbSet<Sysdiagram> Sysdiagrams { get; set; }
        DbSet<Territory> Territories { get; set; }

        void SetAutoDetectChangesEnabled(bool flag);
        void todo();
        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        
        // Stored Procedures
        List<CustOrderHistReturnModel> CustOrderHist(string customerId, out int procResult);
        List<CustOrdersDetailReturnModel> CustOrdersDetail(int? orderId, out int procResult);
        List<CustOrdersOrdersReturnModel> CustOrdersOrders(string customerId, out int procResult);
        List<EmployeeSalesByCountryReturnModel> EmployeeSalesByCountry(DateTime? beginningDate, DateTime? endingDate, out int procResult);
        List<SalesByYearReturnModel> SalesByYear(DateTime? beginningDate, DateTime? endingDate, out int procResult);
        List<SalesByCategoryReturnModel> SalesByCategory(string categoryName, string ordYear, out int procResult);
        List<TenMostExpensiveProductsReturnModel> TenMostExpensiveProducts( out int procResult);

        // Table Valued Functions
        IQueryable<CsvToIntReturnModel> CsvToInt(string array);
    }

}
