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

    // MenuItem
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public partial class MenuItem
    {
        public int Id { get; set; } // Id (Primary key)
        public string Action { get; set; } // Action
        public string Controller { get; set; } // Controller
        public string LinkText { get; set; } // LinkText
        public int ModuleId { get; set; } // ModuleId
        public int? ParentId { get; set; } // ParentId

        public MenuItem()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
