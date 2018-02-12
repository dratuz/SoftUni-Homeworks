public class SolarProvider : Provider
{
    private const int DurabilityIncrease = 500;

    public SolarProvider(string id, double energyOutput, double durability) 
        : base(id, energyOutput, durability)
    {
        this.Durability += DurabilityIncrease;
    }
}
