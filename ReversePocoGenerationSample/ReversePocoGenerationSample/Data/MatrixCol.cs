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

    // MatrixCol
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public partial class MatrixCol
    {

        ///<summary>
        /// ColumnId (Primary key)
        ///</summary>
        public int ColumnId { get; set; }

        ///<summary>
        /// ColumnLabel
        ///</summary>
        public string ColumnLabel { get; set; }

        ///<summary>
        /// QuestionId
        ///</summary>
        public int QuestionId { get; set; }

        ///<summary>
        /// CreatedOn
        ///</summary>
        public System.DateTime? CreatedOn { get; set; }

        ///<summary>
        /// ModifiedOn
        ///</summary>
        public System.DateTime? ModifiedOn { get; set; }

        // Foreign keys
        public virtual Question Question { get; set; } // FK_dbo.MatrixCol_dbo.Question_QuestionId

        public MatrixCol()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
