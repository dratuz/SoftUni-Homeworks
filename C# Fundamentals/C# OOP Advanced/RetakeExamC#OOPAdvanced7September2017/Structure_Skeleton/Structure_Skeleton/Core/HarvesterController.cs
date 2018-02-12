using System;
using System.Collections.Generic;
using System.Linq;

public class HarvesterController : IHarvesterController
{
    private List<IHarvester> harvesters;
    private IOreRepository oreRepository;
    private IHarvesterFactory factory;

    public HarvesterController(double oreProduced)
    {
        this.OreProduced = oreProduced;
        this.harvesters = new List<IHarvester>();
        this.factory = new HarvesterFactory();
    }

    public double OreProduced { get; protected set; }

    public double TotalOreProduced { get; protected set; }

    public string ChangeMode(string mode)
    {
        throw new NotImplementedException();
    }

    public string Produce()
    {
        double oreProduced = this.harvesters.Select(n => n.Produce()).Sum();
        this.oreRepository.StoreOre(oreProduced);
        this.TotalOreProduced += oreProduced;
        List<IHarvester> reminder = new List<IHarvester>();

        foreach (var harvester in this.harvesters)
        {
            try
            {
                harvester.Broke();
            }
            catch (Exception ex)
            {
                reminder.Add(harvester);
            }
        }

        foreach (var entity in reminder)
        {
            this.harvesters.Remove(entity);
        }

        return string.Format(Constants.OreOutputToday, oreProduced);
    }

    public string Register(IList<string> args)
    {
        var harvester = this.factory.GenerateHarvester(args);
        this.harvesters.Add(harvester);
        return string.Format(Constants.SuccessfullRegistration,
            harvester.GetType().Name);
    }
}
