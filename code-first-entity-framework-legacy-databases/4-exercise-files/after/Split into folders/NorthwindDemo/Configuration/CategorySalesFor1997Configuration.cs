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

    // Category Sales for 1997
    public class CategorySalesFor1997Configuration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CategorySalesFor1997>
    {
        public CategorySalesFor1997Configuration()
            : this("dbo")
        {
        }
 
        public CategorySalesFor1997Configuration(string schema)
        {
            ToTable(schema + ".Category Sales for 1997");
            HasKey(x => x.CategoryName);

            Property(x => x.CategoryName).HasColumnName("CategoryName").IsRequired().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.CategorySales).HasColumnName("CategorySales").IsOptional().HasColumnType("money").HasPrecision(19,4);
        }
    }

}
// </auto-generated>
