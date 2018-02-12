public interface IOreRepository
{
    double OreStored { get; }

    double TotalOreProduced { get; }

    void StoreOre(double energy);
}