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
    public partial class FakeNorthwindDbContext : INorthwindDbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerDemographic> CustomerDemographics { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Engineer> Engineers { get; set; }
        public DbSet<EngineerOrder> EngineerOrders { get; set; }
        public DbSet<EngineerOrderItem> EngineerOrderItems { get; set; }
        public DbSet<GeographyType> GeographyTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Sysdiagram> Sysdiagrams { get; set; }
        public DbSet<Territory> Territories { get; set; }

        public FakeNorthwindDbContext()
        {
            Categories = new FakeDbSet<Category>();
            Customers = new FakeDbSet<Customer>();
            CustomerDemographics = new FakeDbSet<CustomerDemographic>();
            Employees = new FakeDbSet<Employee>();
            Engineers = new FakeDbSet<Engineer>();
            EngineerOrders = new FakeDbSet<EngineerOrder>();
            EngineerOrderItems = new FakeDbSet<EngineerOrderItem>();
            GeographyTypes = new FakeDbSet<GeographyType>();
            Orders = new FakeDbSet<Order>();
            OrderDetails = new FakeDbSet<OrderDetail>();
            Products = new FakeDbSet<Product>();
            Regions = new FakeDbSet<Region>();
            Shippers = new FakeDbSet<Shipper>();
            Suppliers = new FakeDbSet<Supplier>();
            Sysdiagrams = new FakeDbSet<Sysdiagram>();
            Territories = new FakeDbSet<Territory>();

            InitializePartial();
        }
        
        public int SaveChangesCount { get; private set; } 
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        partial void InitializePartial();

        protected virtual void Dispose(bool disposing)
        {
        }
        
        public void Dispose()
        {
            Dispose(true);
        }
        
        // Stored Procedures
        public List<CustOrderHistReturnModel> CustOrderHist(string customerId)
        {
            int procResult;
            return CustOrderHist(customerId, out procResult);
        }

        public List<CustOrderHistReturnModel> CustOrderHist(string customerId, out int procResult)
        {
 
            procResult = 0;
            return new List<CustOrderHistReturnModel>();
        }

        public List<CustOrdersDetailReturnModel> CustOrdersDetail(int? orderId)
        {
            int procResult;
            return CustOrdersDetail(orderId, out procResult);
        }

        public List<CustOrdersDetailReturnModel> CustOrdersDetail(int? orderId, out int procResult)
        {
 
            procResult = 0;
            return new List<CustOrdersDetailReturnModel>();
        }

        public List<CustOrdersOrdersReturnModel> CustOrdersOrders(string customerId)
        {
            int procResult;
            return CustOrdersOrders(customerId, out procResult);
        }

        public List<CustOrdersOrdersReturnModel> CustOrdersOrders(string customerId, out int procResult)
        {
 
            procResult = 0;
            return new List<CustOrdersOrdersReturnModel>();
        }

        public List<EmployeeSalesByCountryReturnModel> EmployeeSalesByCountry(DateTime? beginningDate, DateTime? endingDate)
        {
            int procResult;
            return EmployeeSalesByCountry(beginningDate, endingDate, out procResult);
        }

        public List<EmployeeSalesByCountryReturnModel> EmployeeSalesByCountry(DateTime? beginningDate, DateTime? endingDate, out int procResult)
        {
 
            procResult = 0;
            return new List<EmployeeSalesByCountryReturnModel>();
        }

        public List<SalesByYearReturnModel> SalesByYear(DateTime? beginningDate, DateTime? endingDate)
        {
            int procResult;
            return SalesByYear(beginningDate, endingDate, out procResult);
        }

        public List<SalesByYearReturnModel> SalesByYear(DateTime? beginningDate, DateTime? endingDate, out int procResult)
        {
 
            procResult = 0;
            return new List<SalesByYearReturnModel>();
        }

        public List<SalesByCategoryReturnModel> SalesByCategory(string categoryName, string ordYear)
        {
            int procResult;
            return SalesByCategory(categoryName, ordYear, out procResult);
        }

        public List<SalesByCategoryReturnModel> SalesByCategory(string categoryName, string ordYear, out int procResult)
        {
 
            procResult = 0;
            return new List<SalesByCategoryReturnModel>();
        }

        public List<TenMostExpensiveProductsReturnModel> TenMostExpensiveProducts()
        {
            int procResult;
            return TenMostExpensiveProducts(out procResult);
        }

        public List<TenMostExpensiveProductsReturnModel> TenMostExpensiveProducts( out int procResult)
        {
 
            procResult = 0;
            return new List<TenMostExpensiveProductsReturnModel>();
        }

        // Table Valued Functions
        [DbFunction("NorthwindDbContext", "CsvToInt")]
        public IQueryable<CsvToIntReturnModel> CsvToInt(string array)
        {
            return new List<CsvToIntReturnModel>().AsQueryable();
        }

    }
}
