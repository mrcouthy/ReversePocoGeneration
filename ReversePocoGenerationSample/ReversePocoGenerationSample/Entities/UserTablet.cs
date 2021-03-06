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

    // UserTablet
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public partial class UserTablet
    {
        public int UserTabletId { get; set; } // UserTabletId (Primary key)
        public int UserId { get; set; } // UserId
        public int TabletId { get; set; } // TabletId
        public string CreatedBy { get; set; } // CreatedBy
        public System.DateTime? CreatedOn { get; set; } // CreatedOn
        public string ModifiedBy { get; set; } // ModifiedBy
        public System.DateTime? ModifiedOn { get; set; } // ModifiedOn
        public string DeletedBy { get; set; } // DeletedBy
        public System.DateTime? DeletedOn { get; set; } // DeletedOn
        public bool IsActive { get; set; } // IsActive
        public bool IsDeleted { get; set; } // IsDeleted

        // Foreign keys
        public virtual Tablet Tablet { get; set; } // FK_dbo.UserTablet_dbo.Tablet_TabletId
        public virtual User User { get; set; } // FK_dbo.UserTablet_dbo.User_UserId

        public UserTablet()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
