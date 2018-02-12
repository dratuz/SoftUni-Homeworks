using System;

public class Provider : IProvider
{
    public Provider(string id, double energyOutput, double durability)
    {
        this.ID = id;
        this.EnergyOutput = energyOutput;
        this.Durability = durability;
    }

    public string ID { get; protected set; }

    public double EnergyOutput { get; protected set; }

    public virtual double Durability { get; protected set; }

    public void Broke()
    {
        throw new NotImplementedException();
    }

    public double Produce()
    {
        throw new NotImplementedException();
    }

    public void Repair(double val)
    {
        throw new NotImplementedException();
    }
}