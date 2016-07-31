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

    // SurveySection
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public partial class SurveySection
    {
        public int SectionId { get; set; } // SectionId (Primary key)
        public string Code { get; set; } // Code
        public string Title { get; set; } // Title
        public string Description { get; set; } // Description
        public int SurveyId { get; set; } // SurveyId
        public string CreatedBy { get; set; } // CreatedBy
        public System.DateTime? CreatedOn { get; set; } // CreatedOn
        public string ModifiedBy { get; set; } // ModifiedBy
        public System.DateTime? ModifiedOn { get; set; } // ModifiedOn
        public string DeletedBy { get; set; } // DeletedBy
        public System.DateTime? DeletedOn { get; set; } // DeletedOn
        public bool IsActive { get; set; } // IsActive
        public bool IsDeleted { get; set; } // IsDeleted

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<Question> Questions { get; set; } // Question.FK_dbo.Question_dbo.SurveySection_SectionId

        // Foreign keys
        public virtual Survey Survey { get; set; } // FK_dbo.SurveySection_dbo.Survey_SurveyId

        public SurveySection()
        {
            Questions = new yyy<Question>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
