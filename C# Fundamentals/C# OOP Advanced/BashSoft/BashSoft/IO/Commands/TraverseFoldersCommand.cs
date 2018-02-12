namespace BashSoft.IO.Commands
{
    using System;
    using Execptions;
    using BashSoft.Contracts;
    using BashSoft.Attributes;

    [Alias("ls")]
    public class TraverseFoldersCommand : Command
    {
        public TraverseFoldersCommand(string input, string[] data) 
            : base(input, data)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length == 1)
            {
                this.InputOutputManager.TraverseDirectory(0);
            }
            else
            {
                int depth;
                var success = int.TryParse(this.Data[1], out depth);
                if (success)
                {
                    this.InputOutputManager.TraverseDirectory(depth);
                }
                else
                {
                    throw new InvalidNumberParseException();
                }
            }
        }
    }
}
