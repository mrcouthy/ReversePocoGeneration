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
    public class EngineerCompany
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }

        public virtual System.Collections.Generic.ICollection<EngineerPerson> EngineerPersons { get; set; }
        
        public EngineerCompany()
        {
            Description = "";
            PhoneNumber = "please enter a value";
            EngineerPersons = new System.Collections.Generic.List<EngineerPerson>();
        }
    }

}
// </auto-generated>
