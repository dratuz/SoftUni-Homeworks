using System;
using System.Collections.Generic;
using System.Linq;

public class Engine : IEngine
{
    private DraftManager manager;

    public Engine()
    {
        this.manager = new DraftManager();
    }

    public void Run()
    {
        while (true)
        {
            IReader inputReader = new ConsoleReader();
            var input = inputReader.ReadLine();
            
            while ((input = inputReader.ReadLine()) != "Shutdown")
            {
                var data = input.Split(' ').ToList();
                var command = data[0];
                var type = data[1];

                switch (command)
                {
                    case "Register":
                        //var args = new List<string>(data.Skip(1).ToList());
                        if (type == "Harvester")
                        {
                            var argsHarvester = new List<string>(data.Skip(1).ToList());
                            manager.RegisterHarvester(argsHarvester);
                        }
                        else if (type == "Provider")
                        {
                            var argsProvider = new List<string>(data.Skip(1).ToList());
                            manager.RegisterProvider(argsProvider);
                        }
                        break;
                    case "Day":
                        manager.Day();
                        break;
                    case "Mode":
                        var args = new List<string>(data.Skip(1).ToList());
                        manager.Mode(args);
                        break;
                    case "Check":
                        args = new List<string>(data.Skip(1).ToList());
                        IWriter writer = new ConsoleWriter();
                        writer.WriteLine(manager.Check(args));
                        break;
                }
            }
            
            manager.ShutDown();
            Environment.Exit(0);
        }
    }
}
