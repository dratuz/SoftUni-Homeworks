public class PressureProvider : Provider
{
    private const int DurabilityDecreace = 300;
    private const double EnergyOutputMultiply = 2;

    public PressureProvider(string id, double energyOutput, double durability) 
        : base(id, energyOutput, durability)
    {
        this.EnergyOutput *= EnergyOutputMultiply;
        this.Durability -= DurabilityDecreace;
    }
}
