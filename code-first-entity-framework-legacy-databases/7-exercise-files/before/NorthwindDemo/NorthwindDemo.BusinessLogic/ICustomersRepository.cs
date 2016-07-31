using System.Collections.Generic;
using NorthwindDemo.Data;

namespace NorthwindDemo.BusinessLogic
{
    public interface ICustomersRepository
    {
        List<Customer> GetTop10();
        int Count();
        Customer FindByCompanyName(string companyName);
        Customer Find(string id);
        bool AddCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
    }
}
