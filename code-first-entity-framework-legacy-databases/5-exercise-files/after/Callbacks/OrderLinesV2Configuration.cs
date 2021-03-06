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

    // AB_OrderLinesAB_
    public class OrderLinesV2Configuration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<OrderLinesV2>
    {
        public OrderLinesV2Configuration()
            : this("dbo")
        {
        }
 
        public OrderLinesV2Configuration(string schema)
        {
            ToTable(schema + ".AB_OrderLinesAB_");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.OrderId).HasColumnName("OrderID").IsRequired().HasColumnType("int");
            Property(x => x.Sku).HasColumnName("sku").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(15);

            // Foreign keys
            HasRequired(a => a.OrdersV2).WithMany(b => b.OrderLinesV2).HasForeignKey(c => c.OrderId); // AB_OrderLinesAB_FK
        }
    }

}
// </auto-generated>
