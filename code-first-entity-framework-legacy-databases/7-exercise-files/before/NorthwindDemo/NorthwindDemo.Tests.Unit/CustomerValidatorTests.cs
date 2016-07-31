using NorthwindDemo.BusinessLogic;
using NorthwindDemo.Data;
using NUnit.Framework;

namespace NorthwindDemo.Tests.Unit
{
    [TestFixture]
    public class CustomerValidatorTests
    {
        private CustomerValidator _validator;

        [SetUp]
        public void Setup()
        {
            _validator = new CustomerValidator();
        }

        [Test]
        [TestCase("UK", "", false)]
        [TestCase("UK", null, false)]
        [TestCase("UK", "AB111AA", true)]
        [TestCase("UK", "AB11 1AA", true)]
        [TestCase("UK", "AB1 11AA", false)]
        [TestCase("USA", "", true)]
        public void PostcodeValidation(string country, string postcode, bool expected)
        {
            // Arrange
            var customer = new Customer
            {
                CompanyName = "test",
                Country = country,
                PostalCode = postcode
            };

            // Act
            var result = _validator.IsValid(customer);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}