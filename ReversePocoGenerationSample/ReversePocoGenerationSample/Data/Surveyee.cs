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

    // Surveyee
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public partial class Surveyee
    {
        public string Title { get; set; } // Title
        public string Code { get; set; } // Code
        public string Description { get; set; } // Description
        public System.DateTime CreatedOn { get; set; } // CreatedOn
        public System.DateTime? ModifiedOn { get; set; } // ModifiedOn
        public System.DateTime? DeletedOn { get; set; } // DeletedOn
        public int? CreatedBy { get; set; } // CreatedBy
        public int? ModifiedBy { get; set; } // ModifiedBy
        public int? DeletedBy { get; set; } // DeletedBy
        public string Status { get; set; } // Status (length: 10)
        public string SurveyeeGuid { get; set; } // SurveyeeGuid (Primary key) (length: 36)

        public Surveyee()
        {
            CreatedOn = System.DateTime.Now;
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
