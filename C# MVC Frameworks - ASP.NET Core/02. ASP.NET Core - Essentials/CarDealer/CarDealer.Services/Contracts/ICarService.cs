namespace CarDealer.Services.Contracts
{
    using CarDealer.Services.Models;
    using System.Collections.Generic;

    public interface ICarService
    {
        IEnumerable<CarModel> CarsByMake(string make);
    }
}
