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

namespace Callbacks
{

    // tblOrderLines
    public class OrderLinesConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<OrderLines>
    {
        public OrderLinesConfiguration()
            : this("dbo")
        {
        }
 
        public OrderLinesConfiguration(string schema)
        {
            ToTable(schema + ".tblOrderLines");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.OrderId).HasColumnName("OrderID").IsRequired().HasColumnType("int");
            Property(x => x.Sku).HasColumnName("sku").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(15);

            // Foreign keys
            HasRequired(a => a.Orders).WithMany(b => b.OrderLines).HasForeignKey(c => c.OrderId); // tblOrdersFK
        }
    }

}
// </auto-generated>