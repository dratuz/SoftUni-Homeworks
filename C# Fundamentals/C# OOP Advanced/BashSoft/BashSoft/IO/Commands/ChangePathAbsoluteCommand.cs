namespace BashSoft.IO.Commands
{
    using BashSoft.Attributes;
    using BashSoft.Contracts;
    using Execptions;

    [Alias("cdrel")]
    public class ChangePathAbsoluteCommand : Command
    {
        public ChangePathAbsoluteCommand(string input, string[] data) 
            : base(input, data)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            var absPath = this.Data[1];
            this.InputOutputManager.ChangeCurrentDirectoryAbsolute(absPath);
        }
    }
}
