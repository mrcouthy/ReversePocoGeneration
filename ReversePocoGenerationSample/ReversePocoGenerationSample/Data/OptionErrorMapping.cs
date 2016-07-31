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
    public partial class OptionErrorMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<OptionError>
    {
        public OptionErrorMapping()
            : this("dbo")
        {
        }

        public OptionErrorMapping(string schema)
        {
            ToTable("OptionError", schema);
            HasKey(x => x.OptionErrorId);

            Property(x => x.OptionErrorId).HasColumnName(@"OptionErrorId").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.QuestionOptionId).HasColumnName(@"QuestionOptionId").IsRequired().HasColumnType("int");
            Property(x => x.ErrorText).HasColumnName(@"ErrorText").IsOptional().HasColumnType("nvarchar");
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
