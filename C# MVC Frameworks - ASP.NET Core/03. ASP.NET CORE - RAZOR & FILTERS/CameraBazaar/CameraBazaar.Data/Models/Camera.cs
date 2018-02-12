namespace CameraBazaar.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Camera
    {
        public int Id { get; set; }

        public CameraMakeEnum Make { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        [Range(0, 100)]
        public int Quantity { get; set; }

        [Range(0, 30)]
        public int MinShutterSpeed { get; set; }

        [Range(2000, 8000)]
        public int MaxShutterSpeed { get; set; }

        [Range(50, 100)]
        public int MinISO { get; set; }

        [Range(200, 409600)]
        public int MaxISO { get; set; }

        public bool IsFullFrame { get; set; }

        [MaxLength(15)]
        public string VideoResolution { get; set; }

        public LightMeteringEnum LightMetering { get; set; }

        [MaxLength(6000)]
        public string Description { get; set; }
        
        public string ImageURL { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }
    }
}
