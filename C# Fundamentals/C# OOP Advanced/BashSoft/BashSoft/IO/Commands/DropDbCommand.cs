namespace BashSoft.IO.Commands
{
    using BashSoft.Attributes;
    using BashSoft.Contracts;
    using Execptions;

    [Alias("drobdb")]
    public class DropDbCommand : Command
    {
        public DropDbCommand(string input, string[] data)
            : base(input, data)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 1)
            {
                throw new InvalidCommandException(this.Input);
            }

            this.Repository.UnloadData();

            OutputWriter.WriteMessageOnNewLine("Database dropped!");
        }
    }
}
