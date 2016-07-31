// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

namespace NorthwindDemo.Configuration
{
    using NorthwindDemo.Entities;

    // Orders
    public class OrderConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
            : this("dbo")
        {
        }
 
        public OrderConfiguration(string schema)
        {
            ToTable(schema + ".Orders");
            HasKey(x => x.OrderId);

            Property(x => x.OrderId).HasColumnName("OrderID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CustomerId).HasColumnName("CustomerID").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(5);
            Property(x => x.EmployeeId).HasColumnName("EmployeeID").IsOptional().HasColumnType("int");
            Property(x => x.OrderDate).HasColumnName("OrderDate").IsOptional().HasColumnType("datetime");
            Property(x => x.RequiredDate).HasColumnName("RequiredDate").IsOptional().HasColumnType("datetime");
            Property(x => x.ShippedDate).HasColumnName("ShippedDate").IsOptional().HasColumnType("datetime");
            Property(x => x.ShipVia).HasColumnName("ShipVia").IsOptional().HasColumnType("int");
            Property(x => x.Freight).HasColumnName("Freight").IsOptional().HasColumnType("money").HasPrecision(19,4);
            Property(x => x.ShipName).HasColumnName("ShipName").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.ShipAddress).HasColumnName("ShipAddress").IsOptional().HasColumnType("nvarchar").HasMaxLength(60);
            Property(x => x.ShipCity).HasColumnName("ShipCity").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.ShipRegion).HasColumnName("ShipRegion").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.ShipPostalCode).HasColumnName("ShipPostalCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.ShipCountry).HasColumnName("ShipCountry").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);

            // Foreign keys
            HasOptional(a => a.Customer).WithMany(b => b.Orders).HasForeignKey(c => c.CustomerId); // FK_Orders_Customers
            HasOptional(a => a.Employee).WithMany(b => b.Orders).HasForeignKey(c => c.EmployeeId); // FK_Orders_Employees
            HasOptional(a => a.Shipper).WithMany(b => b.Orders).HasForeignKey(c => c.ShipVia); // FK_Orders_Shippers
        }
    }

}
// </auto-generated>
