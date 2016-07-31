using System;
using NorthwindDemo.BusinessLogic;
using NorthwindDemo.Data;

namespace NorthwindDemo
{
    class Program
    {
        static void Main()
        {
            using (var db = new NorthwindDb())
            {
                var customerValidator = new CustomerValidator();
                var customersRepository = new CustomersRepository(db, customerValidator);
                var customers = customersRepository.GetTop10();
                foreach (var customer in customers)
                {
                    Console.WriteLine("{0}", customer.CompanyName);
                }

                Console.WriteLine();
                Console.WriteLine("Adding a customer");

                var result = customersRepository.AddCustomer(new Customer
                {
                    CompanyName = "Test",
                    Country = "UK",
                    PostalCode = "" // "AA11 1AA"
                });
                Console.WriteLine(result ? "Worked" : "Failed");
            }
        }
    }
}
