namespace CarDealer.Data.Models
{
    public class PartCars
    {
        public int CarId { get; set; }

        public Car Car { get; set; }

        public int PartId { get; set; }

        public Part Parts { get; set; }
    }
}
