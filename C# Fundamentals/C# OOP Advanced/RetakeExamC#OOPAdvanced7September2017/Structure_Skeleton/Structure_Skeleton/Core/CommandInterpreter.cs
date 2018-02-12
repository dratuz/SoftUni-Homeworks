using System;
using System.Collections.Generic;
using System.Reflection;

public class CommandInterpreter : ICommandInterpreter
{
    public IHarvesterController HarvesterController { get; protected set; }

    public IProviderController ProviderController { get; protected set; }

    public void ProcessCommand(IList<string> args)
    {
        string commandType = args[0];
        args.RemoveAt(0);

        string commandFullName = commandType;

        try
        {
             this.GetType()
                .GetMethod(commandFullName, BindingFlags.NonPublic | BindingFlags.Instance)
                .Invoke(this, new object[] { args });
        }
        catch (TargetInvocationException tie)
        {
            throw tie.InnerException;
        }
    }

    string ICommandInterpreter.ProcessCommand(IList<string> args)
    {
        throw new NotImplementedException();
    }
}
