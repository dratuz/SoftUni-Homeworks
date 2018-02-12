namespace CarDealer.Services.Implementations
{
    using Data;
    using CarDealer.Services.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System;
    using Microsoft.EntityFrameworkCore.Extensions.Internal;
    using CarDealer.Services.Contracts;

    public class CustomerService : ICustomerService
    {
        private readonly CarDealerDbContext db;

        public CustomerService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<CustomerModel> OrderedCustomers(OrderDirection order)
        {
            var result = this.db.Customers
                .Select(c => new CustomerModel
                {
                    Name = c.Name,
                    BirthDate = c.BirthDate,
                    IsYoungDriver = c.IsYoungDriver
                });

            //var orderedResult =
            //    order == OrderDirection.Ascending
            //    ? result
            //        .OrderBy(c => c.BirthDate)
            //        .ThenBy(c => c.IsYoungDriver)
            //    : result
            //        .OrderByDescending(c => c.BirthDate)
            //        .ThenBy(c => c.IsYoungDriver);
            
            switch (order)
            {
                case OrderDirection.Ascending:
                    result = result
                        .OrderBy(c => c.BirthDate)
                        .ThenBy(c => c.IsYoungDriver);
                    break;
                case OrderDirection.Descending:
                    result = result
                        .OrderByDescending(c => c.BirthDate)
                        .ThenBy(c => c.IsYoungDriver);
                    break;
                default:
                    throw new InvalidOperationException($"Invalid order direction: {order}");
            }

            return result.ToList();
        }
    }
}
