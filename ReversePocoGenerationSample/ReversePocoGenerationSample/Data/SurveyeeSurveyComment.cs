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

    // SurveyeeSurveyComment
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public partial class SurveyeeSurveyComment
    {
        public int CommentId { get; set; } // CommentId (Primary key)
        public int SurveyeeId { get; set; } // SurveyeeId
        public int SurveyId { get; set; } // SurveyId
        public string Comment { get; set; } // Comment

        public SurveyeeSurveyComment()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
