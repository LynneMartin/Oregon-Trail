using System;
using OregonTrail.Project; //REVIEW Is this correct naming convention?
using OregonTrail.Project.Models;

namespace OregonTrail
{
  public class Program
  {
    public static void Main(string[] args)
    {
      GameService game = new GameService();
      game.StartGame();

      //       Console.Clear();
      //       GameService gs = new GameService();
      //       gs.Setup(); //Connected to GameService.cs
      //       gs.Startup();
      //       gs.Run();

      // //NOTE THIS is running at dotnet run
      //       Console.WriteLine(@"

      //      ___   ___   ____  __    ___   _         _____  ___    __    _   _    
      //     / / \ | |_) | |_  / /`_ / / \ | |\ |      | |  | |_)  / /\  | | | |   
      //     \_\_/ |_| \ |_|__ \_\_/ \_\_/ |_| \|      |_|  |_| \ /_/--\ |_| |_|__ 

      //       ");

      //       Console.WriteLine("Welcome to your new adventure! What is your name?");
      //       string name = Console.ReadLine();
      //       Console.Clear();
      //       Player newPlayer = new Player(name);
    }

  }
}
