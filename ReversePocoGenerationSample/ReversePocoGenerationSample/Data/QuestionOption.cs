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
    public partial class QuestionOption
    {
        public int QuestionOptionId { get; set; }
        public string OptionChoiceLabel { get; set; }
        public bool IsDropdown { get; set; }
        public int QuestionId { get; set; }
        public System.DateTime? CreatedOn { get; set; }
        public System.DateTime? ModifiedOn { get; set; }

        public virtual System.Collections.Generic.ICollection<Answer> Answers { get; set; }

        public virtual Question Question { get; set; }

        public QuestionOption()
        {
            Answers = new System.Collections.Generic.List<Answer>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
