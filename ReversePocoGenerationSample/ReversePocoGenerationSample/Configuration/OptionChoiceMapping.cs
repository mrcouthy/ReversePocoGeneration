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

namespace ReversePocoGenerationSample.Configuration
{
    using ReversePocoGenerationSample.Context;
    using ReversePocoGenerationSample.Entities;
    using System;

    // OptionChoice
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public partial class OptionChoiceMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<OptionChoice>
    {
        public OptionChoiceMapping()
            : this("dbo")
        {
        }

        public OptionChoiceMapping(string schema)
        {
            ToTable("OptionChoice", schema);
            HasKey(x => x.OptionChoiceId);

            Property(x => x.OptionChoiceId).HasColumnName(@"OptionChoiceId").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.OptionChoiceLabel).HasColumnName(@"OptionChoiceLabel").IsOptional().HasColumnType("nvarchar");
            Property(x => x.IsDropdown).HasColumnName(@"IsDropdown").IsRequired().HasColumnType("bit");
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
