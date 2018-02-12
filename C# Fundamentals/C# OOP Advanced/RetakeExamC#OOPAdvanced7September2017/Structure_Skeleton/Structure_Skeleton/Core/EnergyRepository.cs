using System;

public class EnergyRepository : IEnergyRepository
{
    public double EnergyStored { get; protected set; }

    public void StoreEnergy(double energy)
    {
        throw new NotImplementedException();
    }

    public bool TakeEnergy(double energyNeeded)
    {
        throw new NotImplementedException();
    }
}
