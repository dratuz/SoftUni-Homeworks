namespace CarDealer.Web.Models.CarsViewModels
{
    using CarDealer.Services.Models;
    using System.Collections.Generic;

    public class CarsByMakeViewModel
    {
        public string Make { get; set; }

        public IEnumerable<CarModel> Cars { get; set; }
    }
}
