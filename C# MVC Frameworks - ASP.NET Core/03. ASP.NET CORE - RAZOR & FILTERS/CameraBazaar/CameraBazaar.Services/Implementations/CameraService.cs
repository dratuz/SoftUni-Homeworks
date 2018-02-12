namespace CameraBazaar.Services.Implementations
{
    using CameraBazaar.Services.Contracts;
    using System;
    using System.Collections.Generic;
    using CameraBazaar.Data.Models;
    using System.Linq;

    class CameraService : ICameraService
    {
        public void Create(
            CameraMakeEnum make, 
            string model, 
            decimal price, 
            int quantity,
            int minShutteredSpeed,
            int maxShutteredSpeed,
            int minISO, 
            int maxISO,
            bool isFullFrame,
            string videoResolution,
            IEnumerable<LightMeteringEnum> lightMeterings, 
            string description, 
            string imageUrl, 
            string userId)
        {
            var camera = new Camera
            {
                Make = make,
                Model = model,
                Price = price,
                Quantity = quantity,
                MinShutterSpeed = minShutteredSpeed,
                MaxShutterSpeed = maxShutteredSpeed,
                MinISO = minISO,
                MaxISO = maxISO,
                IsFullFrame = isFullFrame,
                VideoResolution = videoResolution,
                LightMetering = (LightMeteringEnum)lightMeterings.Cast<int>().Sum(),
                Description = description,
                ImageURL = imageUrl,
                UserId = userId
            };
        }
    }
}
