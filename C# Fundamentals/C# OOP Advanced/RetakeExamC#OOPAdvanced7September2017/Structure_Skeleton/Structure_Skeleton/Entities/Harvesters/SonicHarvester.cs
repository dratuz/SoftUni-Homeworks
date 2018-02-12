public class SonicHarvester : Harvester
{
    private const int EnergyRequirementDivider = 2;
    private const int DurabilityLoss = 300;

    public SonicHarvester(string id, double oreOutput, double energyRequirement) 
        : base(id, oreOutput, energyRequirement)
    {
        this.EnergyRequirement /= EnergyRequirementDivider;
        this.Durability -= DurabilityLoss;
    }
}