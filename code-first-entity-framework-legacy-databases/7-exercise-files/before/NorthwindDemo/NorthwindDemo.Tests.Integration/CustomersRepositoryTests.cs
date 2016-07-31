using System.Collections.Generic;
using System.Linq;
using NorthwindDemo.BusinessLogic;
using NorthwindDemo.Data;
using NUnit.Framework;

/* NOTE: nUnit functions are called like this:
TestFixtureSetUp
    SetUp
        Test 1
    TearDown
    
    SetUp
        Test 2
    TearDown
TestFixtureTearDown

SetUp/TearDown methods are called before and after each test method.
TestFixtureSetUp/TestFixtureTearDown methods are called once for the entire fixture.
*/

namespace NorthwindDemo.Tests.Integration
{
    public class CustomersRepositoryTests
    {
        private CustomerValidator _validator;

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            _validator = new CustomerValidator();
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            var db = new NorthwindDb();
            var customer = db.Customers.FirstOrDefault(x => x.CustomerId == "TEST.");
            if (customer == null)
                return;
            db.Customers.Remove(customer);
            db.SaveChanges();
        }

        [Test]
        // Here is an example of a poor integration test as data may change and break the test
        public void GetTop10()
        {
            // Arrange
            var customersRepository = new CustomersRepository(new NorthwindDb(), _validator);

            // Act
            var data = customersRepository.GetTop10();

            // Assert
            Assert.AreEqual(10, data.Count);

            // Check top 10 results match the following
            var dictionary = new Dictionary<string, string>
            {
                { "ALFKI", "Alfreds Futterkiste" },
                { "ANATR", "Ana Trujillo Emparedados y helados" },
                { "ANTON", "Antonio Moreno Taquería" },
                { "AROUT", "Around the Horn" },
                { "BERGS", "Berglunds snabbköp" },
                { "BLAUS", "Blauer See Delikatessen" },
                { "BLONP", "Blondesddsl père et fils" },
                { "BOLID", "Bólido Comidas preparadas" },
                { "BONAP", "Bon app'" },
                { "BOTTM", "Bottom-Dollar Markets"}
            };
            foreach (var customer in data)
            {
                Assert.IsTrue(dictionary.ContainsKey(customer.CustomerId));
                Assert.AreEqual(dictionary[customer.CustomerId], customer.CompanyName);
            }
        }


        [Test]
        public void Insert_and_delete_TEST_record_succesfully_via_Find()
        {
            // Arrange
            var customersRepository1 = new CustomersRepository(new NorthwindDb(), _validator);
            var customersRepository2 = new CustomersRepository(new NorthwindDb(), _validator);
            var customersRepository3 = new CustomersRepository(new NorthwindDb(), _validator);
            var customer = new Customer
            {
                CustomerId = "TEST.",
                CompanyName = "Integration testing",
                Country = "UK",
                PostalCode = "AB11 1AA"
            };

            // Act / Assert
            var result = customersRepository1.AddCustomer(customer);
            Assert.IsTrue(result);

            var customer2 = customersRepository2.Find(customer.CustomerId);
            Assert.IsNotNull(customer2);
            Assert.AreEqual(customer.CustomerId, customer2.CustomerId);
            Assert.AreEqual(customer.CompanyName, customer2.CompanyName);

            customersRepository2.DeleteCustomer(customer2);

            var customer3 = customersRepository3.Find(customer.CustomerId); // Should not be found
            Assert.IsNull(customer3);
        }
    }
}
