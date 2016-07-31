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
    public partial class NorthwindDbContext : CustomDbContext, INorthwindDbContext
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
        
        static NorthwindDbContext()
        {
            System.Data.Entity.Database.SetInitializer<NorthwindDbContext>(null);
        }

        public NorthwindDbContext()
            : base("Name=Northwind")
        {
            InitializePartial();
        }

        public NorthwindDbContext(string connectionString) : base(connectionString)
        {
            InitializePartial();
        }

        public NorthwindDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
            InitializePartial();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Add(new FunctionsConvention<NorthwindDbContext>("dbo"));
            modelBuilder.ComplexType<CsvToIntReturnModel>();

            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new CustomerDemographicConfiguration());
            modelBuilder.Configurations.Add(new EmployeeConfiguration());
            modelBuilder.Configurations.Add(new EngineerConfiguration());
            modelBuilder.Configurations.Add(new EngineerOrderConfiguration());
            modelBuilder.Configurations.Add(new EngineerOrderItemConfiguration());
            modelBuilder.Configurations.Add(new GeographyTypeConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());
            modelBuilder.Configurations.Add(new OrderDetailConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new RegionConfiguration());
            modelBuilder.Configurations.Add(new ShipperConfiguration());
            modelBuilder.Configurations.Add(new SupplierConfiguration());
            modelBuilder.Configurations.Add(new SysdiagramConfiguration());
            modelBuilder.Configurations.Add(new TerritoryConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new CategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new CustomerConfiguration(schema));
            modelBuilder.Configurations.Add(new CustomerDemographicConfiguration(schema));
            modelBuilder.Configurations.Add(new EmployeeConfiguration(schema));
            modelBuilder.Configurations.Add(new EngineerConfiguration(schema));
            modelBuilder.Configurations.Add(new EngineerOrderConfiguration(schema));
            modelBuilder.Configurations.Add(new EngineerOrderItemConfiguration(schema));
            modelBuilder.Configurations.Add(new GeographyTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new OrderConfiguration(schema));
            modelBuilder.Configurations.Add(new OrderDetailConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductConfiguration(schema));
            modelBuilder.Configurations.Add(new RegionConfiguration(schema));
            modelBuilder.Configurations.Add(new ShipperConfiguration(schema));
            modelBuilder.Configurations.Add(new SupplierConfiguration(schema));
            modelBuilder.Configurations.Add(new SysdiagramConfiguration(schema));
            modelBuilder.Configurations.Add(new TerritoryConfiguration(schema));
            return modelBuilder;
        }

        partial void InitializePartial();
        partial void OnModelCreatingPartial(DbModelBuilder modelBuilder);
        
        // Stored Procedures
        public List<CustOrderHistReturnModel> CustOrderHist(string customerId)
        {
            int procResult;
            return CustOrderHist(customerId, out procResult);
        }

        public List<CustOrderHistReturnModel> CustOrderHist(string customerId, out int procResult)
        {
            var customerIdParam = new SqlParameter { ParameterName = "@CustomerID", SqlDbType = SqlDbType.NChar, Direction = ParameterDirection.Input, Value = customerId, Size = 5 };
            if (customerIdParam.Value == null)
                customerIdParam.Value = DBNull.Value;

            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<CustOrderHistReturnModel>("EXEC @procResult = [dbo].[CustOrderHist] @CustomerID", customerIdParam, procResultParam).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public List<CustOrdersDetailReturnModel> CustOrdersDetail(int? orderId)
        {
            int procResult;
            return CustOrdersDetail(orderId, out procResult);
        }

        public List<CustOrdersDetailReturnModel> CustOrdersDetail(int? orderId, out int procResult)
        {
            var orderIdParam = new SqlParameter { ParameterName = "@OrderID", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = orderId.GetValueOrDefault() };
            if (!orderId.HasValue)
                orderIdParam.Value = DBNull.Value;

            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<CustOrdersDetailReturnModel>("EXEC @procResult = [dbo].[CustOrdersDetail] @OrderID", orderIdParam, procResultParam).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public List<CustOrdersOrdersReturnModel> CustOrdersOrders(string customerId)
        {
            int procResult;
            return CustOrdersOrders(customerId, out procResult);
        }

        public List<CustOrdersOrdersReturnModel> CustOrdersOrders(string customerId, out int procResult)
        {
            var customerIdParam = new SqlParameter { ParameterName = "@CustomerID", SqlDbType = SqlDbType.NChar, Direction = ParameterDirection.Input, Value = customerId, Size = 5 };
            if (customerIdParam.Value == null)
                customerIdParam.Value = DBNull.Value;

            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<CustOrdersOrdersReturnModel>("EXEC @procResult = [dbo].[CustOrdersOrders] @CustomerID", customerIdParam, procResultParam).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public List<EmployeeSalesByCountryReturnModel> EmployeeSalesByCountry(DateTime? beginningDate, DateTime? endingDate)
        {
            int procResult;
            return EmployeeSalesByCountry(beginningDate, endingDate, out procResult);
        }

        public List<EmployeeSalesByCountryReturnModel> EmployeeSalesByCountry(DateTime? beginningDate, DateTime? endingDate, out int procResult)
        {
            var beginningDateParam = new SqlParameter { ParameterName = "@Beginning_Date", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = beginningDate.GetValueOrDefault() };
            if (!beginningDate.HasValue)
                beginningDateParam.Value = DBNull.Value;

            var endingDateParam = new SqlParameter { ParameterName = "@Ending_Date", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = endingDate.GetValueOrDefault() };
            if (!endingDate.HasValue)
                endingDateParam.Value = DBNull.Value;

            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<EmployeeSalesByCountryReturnModel>("EXEC @procResult = [dbo].[Employee Sales by Country] @Beginning_Date, @Ending_Date", beginningDateParam, endingDateParam, procResultParam).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public List<SalesByYearReturnModel> SalesByYear(DateTime? beginningDate, DateTime? endingDate)
        {
            int procResult;
            return SalesByYear(beginningDate, endingDate, out procResult);
        }

        public List<SalesByYearReturnModel> SalesByYear(DateTime? beginningDate, DateTime? endingDate, out int procResult)
        {
            var beginningDateParam = new SqlParameter { ParameterName = "@Beginning_Date", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = beginningDate.GetValueOrDefault() };
            if (!beginningDate.HasValue)
                beginningDateParam.Value = DBNull.Value;

            var endingDateParam = new SqlParameter { ParameterName = "@Ending_Date", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = endingDate.GetValueOrDefault() };
            if (!endingDate.HasValue)
                endingDateParam.Value = DBNull.Value;

            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<SalesByYearReturnModel>("EXEC @procResult = [dbo].[Sales by Year] @Beginning_Date, @Ending_Date", beginningDateParam, endingDateParam, procResultParam).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public List<SalesByCategoryReturnModel> SalesByCategory(string categoryName, string ordYear)
        {
            int procResult;
            return SalesByCategory(categoryName, ordYear, out procResult);
        }

        public List<SalesByCategoryReturnModel> SalesByCategory(string categoryName, string ordYear, out int procResult)
        {
            var categoryNameParam = new SqlParameter { ParameterName = "@CategoryName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = categoryName, Size = 15 };
            if (categoryNameParam.Value == null)
                categoryNameParam.Value = DBNull.Value;

            var ordYearParam = new SqlParameter { ParameterName = "@OrdYear", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = ordYear, Size = 4 };
            if (ordYearParam.Value == null)
                ordYearParam.Value = DBNull.Value;

            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<SalesByCategoryReturnModel>("EXEC @procResult = [dbo].[SalesByCategory] @CategoryName, @OrdYear", categoryNameParam, ordYearParam, procResultParam).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public List<TenMostExpensiveProductsReturnModel> TenMostExpensiveProducts()
        {
            int procResult;
            return TenMostExpensiveProducts(out procResult);
        }

        public List<TenMostExpensiveProductsReturnModel> TenMostExpensiveProducts( out int procResult)
        {
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<TenMostExpensiveProductsReturnModel>("EXEC @procResult = [dbo].[Ten Most Expensive Products] ", procResultParam).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        // Table Valued Functions
        [DbFunction("NorthwindDbContext", "CsvToInt")]
        [DbFunctionDetails(DatabaseSchema = "dbo")]
        public IQueryable<CsvToIntReturnModel> CsvToInt(string array)
        {
            var arrayParam = new ObjectParameter("array", array);
 
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<CsvToIntReturnModel>("[NorthwindDbContext].[CsvToInt](@array)", arrayParam);
        }

    }
}
