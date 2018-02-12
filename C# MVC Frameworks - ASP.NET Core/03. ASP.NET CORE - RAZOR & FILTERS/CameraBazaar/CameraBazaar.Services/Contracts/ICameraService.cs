using CameraBazaar.Data.Models;
using System.Collections.Generic;

namespace CameraBazaar.Services.Contracts
{
    public interface ICameraService
    {
        void Create(
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
            string userId);
    }
}
