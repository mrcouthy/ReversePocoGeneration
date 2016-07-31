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

namespace MigrationDemo
{

    public class EngineerPersonBillingConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EngineerPersonBilling>
    {
        public EngineerPersonBillingConfiguration()
            : this("dbo")
        {
        }
 
        public EngineerPersonBillingConfiguration(string schema)
        {
            ToTable(schema + ".engineer_person_billing");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
// </auto-generated>
