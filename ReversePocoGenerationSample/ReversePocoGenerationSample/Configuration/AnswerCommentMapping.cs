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

    // AnswerComment
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public partial class AnswerCommentMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AnswerComment>
    {
        public AnswerCommentMapping()
            : this("dbo")
        {
        }

        public AnswerCommentMapping(string schema)
        {
            ToTable("AnswerComment", schema);
            HasKey(x => x.QuestionCommentId);

            Property(x => x.QuestionCommentId).HasColumnName(@"QuestionCommentId").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.QuestionId).HasColumnName(@"QuestionId").IsOptional().HasColumnType("int");
            Property(x => x.Comment).HasColumnName(@"Comment").IsOptional().HasColumnType("nvarchar");
            Property(x => x.SurveyeeGuid).HasColumnName(@"SurveyeeGuid").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(36);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
