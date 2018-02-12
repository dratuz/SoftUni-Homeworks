using System;

public abstract class Harvester : IHarvester
{
    private const int InitialDurability = 1000;
    
    //private double oreOutput;
    //private double energyRequirement;

    protected Harvester(string id, double oreOutput, double energyRequirement)
    {
        this.ID = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
        this.Durability = InitialDurability;
    }

    public string ID { get; }

    public double OreOutput { get; protected set; }

    public double EnergyRequirement { get; protected set; }

    public virtual double Durability { get; protected set; }

    public void Broke()
    {
        throw new NotImplementedException();
    }

    public double Produce()
    {
        throw new NotImplementedException();
    }
}