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

    // QuestionOption
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public partial class QuestionOption
    {
        public int QuestionOptionId { get; set; } // QuestionOptionId (Primary key)
        public string OptionChoiceLabel { get; set; } // OptionChoiceLabel
        public bool IsDropdown { get; set; } // IsDropdown
        public int QuestionId { get; set; } // QuestionId
        public System.DateTime? CreatedOn { get; set; } // CreatedOn
        public System.DateTime? ModifiedOn { get; set; } // ModifiedOn

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<Answer> Answers { get; set; } // Answer.FK_Answer_QuestionOption

        // Foreign keys
        public virtual Question Question { get; set; } // FK_dbo.QuestionOption_dbo.Question_QuestionId

        public QuestionOption()
        {
            Answers = new yyy<Answer>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
