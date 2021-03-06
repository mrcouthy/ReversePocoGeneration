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

    // SurveySection
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public partial class SurveySectionMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SurveySection>
    {
        public SurveySectionMapping()
            : this("dbo")
        {
        }

        public SurveySectionMapping(string schema)
        {
            ToTable("SurveySection", schema);
            HasKey(x => x.SectionId);

            Property(x => x.SectionId).HasColumnName(@"SectionId").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsOptional().HasColumnType("nvarchar");
            Property(x => x.Title).HasColumnName(@"Title").IsOptional().HasColumnType("nvarchar");
            Property(x => x.Description).HasColumnName(@"Description").IsOptional().HasColumnType("nvarchar");
            Property(x => x.SurveyId).HasColumnName(@"SurveyId").IsRequired().HasColumnType("int");
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").IsOptional().HasColumnType("nvarchar");
            Property(x => x.CreatedOn).HasColumnName(@"CreatedOn").IsOptional().HasColumnType("datetime");
            Property(x => x.ModifiedBy).HasColumnName(@"ModifiedBy").IsOptional().HasColumnType("nvarchar");
            Property(x => x.ModifiedOn).HasColumnName(@"ModifiedOn").IsOptional().HasColumnType("datetime");
            Property(x => x.DeletedBy).HasColumnName(@"DeletedBy").IsOptional().HasColumnType("nvarchar");
            Property(x => x.DeletedOn).HasColumnName(@"DeletedOn").IsOptional().HasColumnType("datetime");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.IsDeleted).HasColumnName(@"IsDeleted").IsRequired().HasColumnType("bit");

            // Foreign keys
            HasRequired(a => a.Survey).WithMany(b => b.SurveySections).HasForeignKey(c => c.SurveyId); // FK_dbo.SurveySection_dbo.Survey_SurveyId
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
