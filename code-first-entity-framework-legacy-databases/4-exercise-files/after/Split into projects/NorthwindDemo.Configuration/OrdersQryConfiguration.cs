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

    // Orders Qry
    public class OrdersQryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<OrdersQry>
    {
        public OrdersQryConfiguration()
            : this("dbo")
        {
        }
 
        public OrdersQryConfiguration(string schema)
        {
            ToTable(schema + ".Orders Qry");
            HasKey(x => new { x.OrderId, x.CompanyName });

            Property(x => x.OrderId).HasColumnName("OrderID").IsRequired().HasColumnType("int");
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
            Property(x => x.CompanyName).HasColumnName("CompanyName").IsRequired().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.Address).HasColumnName("Address").IsOptional().HasColumnType("nvarchar").HasMaxLength(60);
            Property(x => x.City).HasColumnName("City").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.Region).HasColumnName("Region").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.PostalCode).HasColumnName("PostalCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.Country).HasColumnName("Country").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
        }
    }

}
// </auto-generated>
