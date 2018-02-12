namespace CarDealer.Services.Contracts
{
    using CarDealer.Services.Models;
    using System.Collections.Generic;

    public interface ICustomerService
    {
        IEnumerable<CustomerModel> OrderedCustomers(OrderDirection order);
    }
}
