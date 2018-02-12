namespace BashSoft.IO.Commands
{
    using Execptions;
    using BashSoft.Attributes;

    [Alias("mkdir")]
    public class MakeDirectoryCommand : Command
    {
        public MakeDirectoryCommand(string input, string[] data) 
            : base(input, data)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            var folderName = this.Data[1];
            InputOutputManager.CreateDirectoryInCurrentFolder(folderName);
        }
    }
}
