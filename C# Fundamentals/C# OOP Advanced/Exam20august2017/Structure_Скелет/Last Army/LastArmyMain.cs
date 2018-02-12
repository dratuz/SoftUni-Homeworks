using System;
using System.Text;

class LastArmyMain
{
    static void Main()
    {
        IReader input = new ConsoleReader();
        var gameController = new GameController();
        var result = new StringBuilder();

        while (!input.Equals("Enough! Pull back!"))
        {
            try
            {
                gameController.GiveInputToGameController(input);
            }
            catch (ArgumentException arg)
            {
                result.AppendLine(arg.Message);
            }
            input = new ConsoleReader();
        }

        gameController.RequestResult(result);
        var writher = new ConsoleWriter();

        writher.WriteLine(result.ToString());
    }
}