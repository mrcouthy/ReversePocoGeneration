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

    // tblOrderLines
    public class OrderLines /* Column count = 3 */
    {
        // No of columns for table OrderLines = 3
        public static int ColumnCount = 3;

        [DemoAttribute] public int Id { get; set; } // ID (Primary key)
        public int OrderId { get; set; } // OrderID /*todo*/
        public string Sku { get; set; } // sku /*todo*/

        // Foreign keys
        public virtual Orders Orders { get; set; } // tblOrdersFK
    }

}
// </auto-generated>
