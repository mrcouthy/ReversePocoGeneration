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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.19.0.0")]
    public class TableWithSpace
    {
        public int Id { get; set; }

        public virtual System.Collections.Generic.ICollection<TableWithSpaceAndInColumn> TableWithSpaceAndInColumns { get; set; }
        
        public TableWithSpace()
        {
            TableWithSpaceAndInColumns = new System.Collections.Generic.List<TableWithSpaceAndInColumn>();
        }
    }

}
// </auto-generated>
