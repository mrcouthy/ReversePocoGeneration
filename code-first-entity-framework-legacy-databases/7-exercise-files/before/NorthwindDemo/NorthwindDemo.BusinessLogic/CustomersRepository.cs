using System;
using System.Collections.Generic;
using System.Linq;
using NorthwindDemo.Data;

namespace NorthwindDemo.BusinessLogic
{
    public class CustomersRepository : ICustomersRepository
    {
        private readonly INorthwindDb _context;
        private readonly IValidator<Customer> _validator;

        public CustomersRepository(INorthwindDb context, IValidator<Customer> validator)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));
            _context = context;
            _validator = validator;
        }

        public List<Customer> GetTop10()
        {
            return _context.Customers.Take(10).OrderBy(x => x.CustomerId).ToList();
        }

        public int Count()
        {
            return _context.Customers.Count();
        }

        public Customer FindByCompanyName(string companyName)
        {
            if (string.IsNullOrWhiteSpace(companyName))
                return null;

            return _context.Customers.FirstOrDefault(x => x.CompanyName == companyName);
        }

        public Customer Find(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return null;

            return _context.Customers.Find(id);
        }

        public bool AddCustomer(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException(nameof(customer));

            if (!_validator.IsValid(customer))
                return false;

            _context.Customers.Add(customer);
            _context.SaveChanges();
            return true;
        }

        public void DeleteCustomer(Customer customer)
        {
            if (customer == null || string.IsNullOrWhiteSpace(customer.CustomerId))
                return;

            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }
    }
}