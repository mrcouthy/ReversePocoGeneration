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

    // Colour
    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.18.1.0")]
    public class Colour /* Column count = 2 */
    {
        // No of columns for table Colour = 2
        public static int ColumnCount = 2;

        [DemoAttribute] public CarColour Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name /*todo*/

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<Car> Car_CarId { get; set; } // Many to many mapping
        public virtual System.Collections.Generic.ICollection<Car> Car_PrimaryColourId { get; set; } // Car.CarPrimaryColourFK
        
        public Colour()
        {
            Car_PrimaryColourId = new System.Collections.Generic.List<Car>();
            Car_CarId = new System.Collections.Generic.List<Car>();
        }
    }

}
// </auto-generated>
