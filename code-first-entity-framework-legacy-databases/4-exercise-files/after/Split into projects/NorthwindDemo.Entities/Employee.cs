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

namespace NorthwindDemo.Entities
{

    // Employees
    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.18.1.0")]
    public class Employee
    {
        public int EmployeeId { get; set; } // EmployeeID (Primary key)
        public string LastName { get; set; } // LastName
        public string FirstName { get; set; } // FirstName
        public string Title { get; set; } // Title
        public string TitleOfCourtesy { get; set; } // TitleOfCourtesy
        public System.DateTime? BirthDate { get; set; } // BirthDate
        public System.DateTime? HireDate { get; set; } // HireDate
        public string Address { get; set; } // Address
        public string City { get; set; } // City
        public string Region { get; set; } // Region
        public string PostalCode { get; set; } // PostalCode
        public string Country { get; set; } // Country
        public string HomePhone { get; set; } // HomePhone
        public string Extension { get; set; } // Extension
        public byte[] Photo { get; set; } // Photo
        public string Notes { get; set; } // Notes
        public int? ReportsTo { get; set; } // ReportsTo
        public string PhotoPath { get; set; } // PhotoPath

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<Employee> Employees { get; set; } // Employees.FK_Employees_Employees
        public virtual System.Collections.Generic.ICollection<Order> Orders { get; set; } // Orders.FK_Orders_Employees
        public virtual System.Collections.Generic.ICollection<Territory> Territories { get; set; } // Many to many mapping

        // Foreign keys
        public virtual Employee Employee_ReportsTo { get; set; } // FK_Employees_Employees
        
        public Employee()
        {
            Employees = new System.Collections.Generic.List<Employee>();
            Orders = new System.Collections.Generic.List<Order>();
            Territories = new System.Collections.Generic.List<Territory>();
        }
    }

}
// </auto-generated>