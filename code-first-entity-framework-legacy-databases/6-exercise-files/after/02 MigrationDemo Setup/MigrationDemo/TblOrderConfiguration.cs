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

    public class TblOrderConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TblOrder>
    {
        public TblOrderConfiguration()
            : this("dbo")
        {
        }
 
        public TblOrderConfiguration(string schema)
        {
            ToTable(schema + ".tblOrders");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Added).HasColumnName("added").IsRequired().HasColumnType("datetime");
        }
    }

}
// </auto-generated>
