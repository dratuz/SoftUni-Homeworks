﻿using System;
using System.Collections.Generic;

public class ShutdownCommand : ICommand
{
    public IList<string> Arguments { get; }

    public string Execute()
    {
        throw new NotImplementedException();
    }
}