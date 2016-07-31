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

    // MatrixRow
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public partial class MatrixRow
    {
        public int RowId { get; set; } // RowId (Primary key)
        public string RowLabel { get; set; } // RowLabel
        public int QuestionId { get; set; } // QuestionId
        public System.DateTime? CreatedOn { get; set; } // CreatedOn
        public System.DateTime? ModifiedOn { get; set; } // ModifiedOn

        // Foreign keys
        public virtual Question Question { get; set; } // FK_dbo.MatrixRow_dbo.Question_QuestionId

        public MatrixRow()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
