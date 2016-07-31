using System.Collections.Generic;
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

namespace NorthwindDemo.Tests.Unit
{
    [TestFixture]
    public class CustomersRepositoryTests
    {
        private ICustomersRepository _customersRepository;
        private INorthwindDb _context;
        private CustomerValidator _validator;

        [SetUp]
        public void Setup()
        {
            // Arrange
            _context = new FakeNorthwindDb();
            _validator = new CustomerValidator();

            var list = new List<Customer>
            {
                new Customer
                {
                    CustomerId = "1",
                    CompanyName = "abc"
                },
                new Customer
                {
                    CustomerId = "2",
                    CompanyName = "def"
                }
            };

            _context.Customers.AddRange(list);
            _customersRepository = new CustomersRepository(_context, _validator);
        }

        [Test]
        public void GetCount()
        {
            // Act
            var count = _customersRepository.Count();

            // Assert
            Assert.AreEqual(2, count);
        }

        [Test]
        public void GetTop10()
        {
            // Act
            var customers = _customersRepository.GetTop10();

            Assert.AreEqual(2, customers.Count);
            Assert.AreEqual("abc", customers[0].CompanyName);
            Assert.AreEqual("def", customers[1].CompanyName);
        }

        [Test]
        [TestCase("1", "abc")]
        [TestCase("2", "def")]
        public void Find_ShouldFind(string id, string expectedCompanyName)
        {
            // Act
            var result = _customersRepository.Find(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedCompanyName, result.CompanyName);
        }

        [Test]
        [TestCase("123")]
        [TestCase("   ")]
        [TestCase("")]
        [TestCase(null)]
        public void Find_ShouldNotFind(string id)
        {
            // Act
            var result = _customersRepository.Find(id);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        [TestCase("abc", "1")]
        [TestCase("def", "2")]
        public void FindByCompanyName_ShouldFind(string companyName, string expectedId)
        {
            // Act
            var customer = _customersRepository.FindByCompanyName(companyName);

            // Assert
            Assert.IsNotNull(customer);
            Assert.AreEqual(companyName, customer.CompanyName);
        }

        [Test]
        [TestCase("not a valid company name")]
        [TestCase("   ")]
        [TestCase("")]
        [TestCase(null)]
        public void FindByCompanyName_ShouldNotFind(string companyName)
        {
            // Act
            var result = _customersRepository.FindByCompanyName(companyName);

            // Assert
            Assert.IsNull(result);
        }
    }
}