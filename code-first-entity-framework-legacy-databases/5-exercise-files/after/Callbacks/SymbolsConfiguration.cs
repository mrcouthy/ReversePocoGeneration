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

    // Symbols
    public class SymbolsConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Symbols>
    {
        public SymbolsConfiguration()
            : this("dbo")
        {
        }
 
        public SymbolsConfiguration(string schema)
        {
            ToTable(schema + ".Symbols");
            HasKey(x => x.Dollar);

            Property(x => x.Dollar).HasColumnName("$").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Percent).HasColumnName("%").IsOptional().HasColumnType("int");
            Property(x => x.Pound).HasColumnName("£").IsOptional().HasColumnType("int");
            Property(x => x.Callback).HasColumnName("&callbacks$").IsOptional().HasColumnType("int");
        }
    }

}
// </auto-generated>
