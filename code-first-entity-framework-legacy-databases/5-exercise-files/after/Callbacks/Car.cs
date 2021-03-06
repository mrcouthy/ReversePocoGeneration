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
    [DemoAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.18.1.0")]
    public class Car : CarBase /* Column count = 3 */
    {
        // No of columns for table Car = 3
        public static int ColumnCount = 3;

        [DemoAttribute] public int Id { get; set; } // Id (Primary key)
        public CarColour PrimaryColourId { get; set; } // PrimaryColourId /*todo*/
        public string CarMake { get; set; } // CarMake /*todo*/

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<Colour> Colour_ColourId { get; set; } // Many to many mapping

        // Foreign keys
        public virtual Colour Colour_PrimaryColourId { get; set; } // CarPrimaryColourFK
        
        public Car()
        {
            Colour_ColourId = new System.Collections.Generic.List<Colour>();
        }
    }

}
// </auto-generated>
