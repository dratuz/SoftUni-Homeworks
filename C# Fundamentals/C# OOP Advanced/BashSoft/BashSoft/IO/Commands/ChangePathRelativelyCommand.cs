namespace BashSoft.IO.Commands
{
    using BashSoft.Attributes;
    using Execptions;

    [Alias("cdrel")]
    public class ChangePathRelativelyCommand : Command
    {
        public ChangePathRelativelyCommand(string input, string[] data) 
            : base(input, data)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            var relPath = this.Data[1];

            this.InputOutputManager.ChangeCurrentDirectoryRelative(relPath);
        }
    }
}
