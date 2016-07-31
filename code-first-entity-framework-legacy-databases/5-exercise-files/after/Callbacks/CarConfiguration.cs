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

namespace Callbacks
{

    // Car
    public class CarConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Car>
    {
        public CarConfiguration()
            : this("dbo")
        {
        }
 
        public CarConfiguration(string schema)
        {
            ToTable(schema + ".Car");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PrimaryColourId).HasColumnName("PrimaryColourId").IsRequired().HasColumnType("int");
            Property(x => x.CarMake).HasColumnName("CarMake").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.Colour_PrimaryColourId).WithMany(b => b.Car_PrimaryColourId).HasForeignKey(c => c.PrimaryColourId); // CarPrimaryColourFK
            HasMany(t => t.Colour_ColourId).WithMany(t => t.Car_CarId).Map(m => 
            {
                m.ToTable("CarToColour", "dbo");
                m.MapLeftKey("CarId");
                m.MapRightKey("ColourId");
            });
        }
    }

}
// </auto-generated>