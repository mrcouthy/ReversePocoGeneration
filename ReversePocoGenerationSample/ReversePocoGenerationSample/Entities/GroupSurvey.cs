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

namespace ReversePocoGenerationSample.Entities
{
    using System;

    // GroupSurvey
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public partial class GroupSurvey
    {
        public int GroupSurveyId { get; set; } // GroupSurveyId (Primary key)
        public int GroupId { get; set; } // GroupId
        public int SurveyId { get; set; } // SurveyId
        public string CreatedBy { get; set; } // CreatedBy
        public System.DateTime? CreatedOn { get; set; } // CreatedOn
        public string ModifiedBy { get; set; } // ModifiedBy
        public System.DateTime? ModifiedOn { get; set; } // ModifiedOn
        public string DeletedBy { get; set; } // DeletedBy
        public System.DateTime? DeletedOn { get; set; } // DeletedOn
        public bool IsActive { get; set; } // IsActive
        public bool IsDeleted { get; set; } // IsDeleted

        // Foreign keys
        public virtual Group Group { get; set; } // FK_dbo.GroupSurvey_dbo.Group_GroupId
        public virtual Survey Survey { get; set; } // FK_dbo.GroupSurvey_dbo.Survey_SurveyId

        public GroupSurvey()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
