namespace CarDealer.Web.Controllers
{
    using CarDealer.Services.Contracts;
    using CarDealer.Web.Models.CarsViewModels;
    using Microsoft.AspNetCore.Mvc;

    public class CarController : Controller
    {
        private readonly ICarService cars;

        public CarController(ICarService cars)
        {
            this.cars = cars;
        }

        [Route("/cars/{make}")]
        public IActionResult ByMake(string make)
        {
            var carsByMake = this.cars.CarsByMake(make);
            
            return View(new CarsByMakeViewModel
            {
                Make = make,
                Cars = carsByMake
            });
        }
    }
}