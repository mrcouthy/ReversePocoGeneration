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

    public class TableWithSpaceAndInColumnConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TableWithSpaceAndInColumn>
    {
        public TableWithSpaceAndInColumnConfiguration()
            : this("dbo")
        {
        }
 
        public TableWithSpaceAndInColumnConfiguration(string schema)
        {
            ToTable(schema + ".table with space and in columns");
            HasKey(x => x.Idvalue);

            Property(x => x.Idvalue).HasColumnName("id value").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
// </auto-generated>
