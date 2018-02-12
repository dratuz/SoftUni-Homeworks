using System;
using System.Collections.Generic;

public class ConsoleWriter : IWriter
{
    //private List<string> arguments;

    //public ConsoleWriter()
    //{
    //    this.arguments = new List<string>();
    //}

    //public string StoredMessage
    //{
    //    get => this.arguments.ToString();
    //}

    public void WriteLine(string message)
    {
        Console.WriteLine(message);
    }
}
