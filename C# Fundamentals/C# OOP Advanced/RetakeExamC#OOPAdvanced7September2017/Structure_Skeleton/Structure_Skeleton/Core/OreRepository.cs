using System;

public class OreRepository : IOreRepository
{
    public double OreStored { get; protected set; }

    public double TotalOreProduced { get; protected set; }

    public void StoreOre(double energy)
    {
        throw new NotImplementedException();
    }
}
