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

namespace ReversePocoGenerationSample.Data
{

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public partial class RuleMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Rule>
    {
        public RuleMapping()
            : this("dbo")
        {
        }

        public RuleMapping(string schema)
        {
            ToTable("Rule", schema);
            HasKey(x => x.RuleId);

            Property(x => x.RuleId).HasColumnName(@"RuleId").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").IsOptional().HasColumnType("nvarchar");
            Property(x => x.Description).HasColumnName(@"Description").IsOptional().HasColumnType("nvarchar");
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
