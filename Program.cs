using System;
using OregonTrail.Project; //REVIEW Is this correct naming convention?

namespace OregonTrail
{
    public class Program
    {
        public static void Main(string[] args)
        {
      Console.Clear();
      GameService gameService = new GameService();
      gameService.Startup();
      gameService.Run();
      Console.WriteLine("Welcome to the Oregon Trail! Press enter to begin.");
      Console.ReadKey(); //press any key to continue
    }

    }
}
