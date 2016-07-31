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

    // User
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public partial class UserMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<User>
    {
        public UserMapping()
            : this("dbo")
        {
        }

        public UserMapping(string schema)
        {
            ToTable("User", schema);
            HasKey(x => x.UserId);

            Property(x => x.UserId).HasColumnName(@"UserId").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.FirstName).HasColumnName(@"FirstName").IsOptional().HasColumnType("nvarchar");
            Property(x => x.LastName).HasColumnName(@"LastName").IsOptional().HasColumnType("nvarchar");
            Property(x => x.Address).HasColumnName(@"Address").IsOptional().HasColumnType("nvarchar");
            Property(x => x.Phone).HasColumnName(@"Phone").IsOptional().HasColumnType("nvarchar");
            Property(x => x.UserName).HasColumnName(@"UserName").IsOptional().HasColumnType("nvarchar");
            Property(x => x.Password).HasColumnName(@"Password").IsOptional().HasColumnType("nvarchar");
            Property(x => x.LastLoginDate).HasColumnName(@"LastLoginDate").IsRequired().HasColumnType("datetime");
            Property(x => x.PwdChangeDays).HasColumnName(@"PwdChangeDays").IsRequired().HasColumnType("int");
            Property(x => x.PwdChangeWarningDays).HasColumnName(@"PwdChangeWarningDays").IsRequired().HasColumnType("int");
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").IsOptional().HasColumnType("nvarchar");
            Property(x => x.CreatedOn).HasColumnName(@"CreatedOn").IsOptional().HasColumnType("datetime");
            Property(x => x.ModifiedBy).HasColumnName(@"ModifiedBy").IsOptional().HasColumnType("nvarchar");
            Property(x => x.ModifiedOn).HasColumnName(@"ModifiedOn").IsOptional().HasColumnType("datetime");
            Property(x => x.DeletedBy).HasColumnName(@"DeletedBy").IsOptional().HasColumnType("nvarchar");
            Property(x => x.DeletedOn).HasColumnName(@"DeletedOn").IsOptional().HasColumnType("datetime");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.IsDeleted).HasColumnName(@"IsDeleted").IsRequired().HasColumnType("bit");
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>