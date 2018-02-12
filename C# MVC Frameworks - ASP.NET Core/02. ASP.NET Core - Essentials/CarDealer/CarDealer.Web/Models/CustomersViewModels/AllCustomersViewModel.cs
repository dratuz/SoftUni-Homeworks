namespace CarDealer.Web.Models.CustomersViewModels
{
    using CarDealer.Services.Models;
    using System.Collections.Generic;

    public class AllCustomersViewModel
    {
        public IEnumerable<CustomerModel> Customers { get; set; }

        public OrderDirection OrderDirection { get; set; }
    }
}
