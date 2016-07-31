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

namespace MigrationDemo
{

    public class TblOrderLineConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TblOrderLine>
    {
        public TblOrderLineConfiguration()
            : this("dbo")
        {
        }
 
        public TblOrderLineConfiguration(string schema)
        {
            ToTable(schema + ".tblOrderLines");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.OrderId).HasColumnName("OrderID").IsRequired().HasColumnType("int");
            Property(x => x.Sku).HasColumnName("sku").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(15);

            HasRequired(a => a.TblOrder).WithMany(b => b.TblOrderLines).HasForeignKey(c => c.OrderId);
        }
    }

}
// </auto-generated>
