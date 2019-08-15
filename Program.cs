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
    }

    }
}
