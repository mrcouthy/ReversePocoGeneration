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
    public partial class Organization
    {
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public System.DateTime? ModifiedOn { get; set; }
        public string DeletedBy { get; set; }
        public System.DateTime? DeletedOn { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public virtual System.Collections.Generic.ICollection<Survey> Surveys { get; set; }

        public Organization()
        {
            Surveys = new System.Collections.Generic.List<Survey>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
