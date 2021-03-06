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

namespace ReversePocoGenerationSample.Configuration
{
    using ReversePocoGenerationSample.Context;
    using ReversePocoGenerationSample.Entities;
    using System;

    // UserGroup
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public partial class UserGroupMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<UserGroup>
    {
        public UserGroupMapping()
            : this("dbo")
        {
        }

        public UserGroupMapping(string schema)
        {
            ToTable("UserGroup", schema);
            HasKey(x => x.UserGroupId);

            Property(x => x.UserGroupId).HasColumnName(@"UserGroupId").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UserId).HasColumnName(@"UserId").IsRequired().HasColumnType("int");
            Property(x => x.GroupId).HasColumnName(@"GroupId").IsRequired().HasColumnType("int");
            Property(x => x.IsSuperVisor).HasColumnName(@"IsSuperVisor").IsRequired().HasColumnType("bit");
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").IsOptional().HasColumnType("nvarchar");
            Property(x => x.CreatedOn).HasColumnName(@"CreatedOn").IsOptional().HasColumnType("datetime");
            Property(x => x.ModifiedBy).HasColumnName(@"ModifiedBy").IsOptional().HasColumnType("nvarchar");
            Property(x => x.ModifiedOn).HasColumnName(@"ModifiedOn").IsOptional().HasColumnType("datetime");
            Property(x => x.DeletedBy).HasColumnName(@"DeletedBy").IsOptional().HasColumnType("nvarchar");
            Property(x => x.DeletedOn).HasColumnName(@"DeletedOn").IsOptional().HasColumnType("datetime");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.IsDeleted).HasColumnName(@"IsDeleted").IsRequired().HasColumnType("bit");

            // Foreign keys
            HasRequired(a => a.Group).WithMany(b => b.UserGroups).HasForeignKey(c => c.GroupId); // FK_dbo.UserGroup_dbo.Group_GroupId
            HasRequired(a => a.User).WithMany(b => b.UserGroups).HasForeignKey(c => c.UserId); // FK_dbo.UserGroup_dbo.User_UserId
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
