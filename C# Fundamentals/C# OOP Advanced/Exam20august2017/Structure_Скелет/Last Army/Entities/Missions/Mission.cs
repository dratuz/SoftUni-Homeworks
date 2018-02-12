using System.Collections.Generic;

public abstract class Mission : IMission
{
    public Mission(double endurance, double score)
    {
        this.EnduranceRequired = endurance;
        this.ScoreToComplete = score;
    }

    public string Name { get; }

    public double EnduranceRequired { get; }

    public double ScoreToComplete { get; }

    public double WearLevelDecrement { get; }

    public IEnumerable<IAmmunition> MissionWeapons { get; set; }
}
