using System.Text.RegularExpressions;
using NorthwindDemo.Data;

namespace NorthwindDemo.BusinessLogic
{
    public class CustomerValidator : IValidator<Customer>
    {
        public bool IsValid(Customer customer)
        {
            if (string.IsNullOrWhiteSpace(customer.CompanyName))
                return false;

            if (string.IsNullOrWhiteSpace(customer.Country))
                return false;

            if (customer.Country == "UK")
            {
                // Validate UK postcode.
                if (string.IsNullOrEmpty(customer.PostalCode))
                    return false;

                var ukPostcode = new Regex(@"^(GIR ?0AA|[A-PR-UWYZ]([0-9]{1,2}|([A-HK-Y][0-9]([0-9ABEHMNPRV-Y])?)|[0-9][A-HJKPS-UW]) ?[0-9][ABD-HJLNP-UW-Z]{2})$");
                if (!ukPostcode.IsMatch(customer.PostalCode))
                    return false; // Postcode is invalid
            }

            // Todo: Validate other fields

            return true;
        }
    }
}