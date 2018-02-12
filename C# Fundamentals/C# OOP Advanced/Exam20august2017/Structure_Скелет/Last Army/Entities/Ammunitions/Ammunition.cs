using System;

public abstract class Ammunition : IAmmunition
{
    public Ammunition(string name, double weight)
    {
        Name = name;
        Weight = weight;
    }

    public string Name { get; }

    public double Weight { get; }

    public double WearLevel { get; }

    public void DecreaseWearLevel(double wearAmount)
    {
        throw new NotImplementedException();
    }

    internal void DecreaseWearLevel(Mission mission)
    {
        throw new NotImplementedException();
    }
}
