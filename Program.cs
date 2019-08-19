using System;
using OregonTrail.Project; //REVIEW Is this correct naming convention?
using OregonTrail.Project.Models;

namespace OregonTrail
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.Clear();
      GameService gs = new GameService();
      gs.Setup(); //Connected to GameService.cs
      gs.Startup();
      gs.Run();

      Console.WriteLine(@"

     ___   ___   ____  __    ___   _         _____  ___    __    _   _    
    / / \ | |_) | |_  / /`_ / / \ | |\ |      | |  | |_)  / /\  | | | |   
    \_\_/ |_| \ |_|__ \_\_/ \_\_/ |_| \|      |_|  |_| \ /_/--\ |_| |_|__ 
  
    ｉ⌒ｉ⌒ｉ⌒ｉ⌒ ｉ⌒ ｉ⌒ｉ⌒ｉ⌒ｉ⌒ｉ⌒ｉ⌒ ｉ  
 　　|　 |　 |　 |　 |　 |　 |　 |　 |　 |　 |　 |　　　　　　　　　　　 　 　 　,、  
 　　|　 |　 |　 |　 |　 |　 |　 |　 |　 |　 |　 |´∀｀）　　 　　　　　　　　　〈 ｉ 
 　　|　 |　 |　 |　 |　 |　 |　 |　 |　 |　 |　 |'~ﾌ∞､ ＿　＿__ __ _ 　　　_､シ从ヾ、  
 　　|　 |　 |　 |　 |　 |　 |　 |　 |　 |　 |　 |/_,ハ　　　　　　 ＿￣_,,シ:'｢|ヽ.・ヽ 
 　　|＿ |＿ |＿ |＿ |＿ |＿ |＿ |＿ |＿ |＿ |＿ |三}､_）/7 　　/⌒　￣　|| 　 ||_ へ._）
 　　|三三三三三三三三三三三三三三三三三三三三三三三三}／ノ 　 ,ｲ{　　 ノ　||（ ,Ｕ  
 　　|三／´|｀ヾ三三三三三／´|｀ヾ三三三三三三三三三三ﾚ'ニニニニニニニニニニニ０ニｺ/  
 　  └ﾞ （─＠─）======== （─＠─）=┘　　 　 　 　             /|　|　　　　}　j{  
 　 　 ＼._|_,ノ　 　 　 ＼._|_,ノ　　　　　　 　　　       《_,ヒ｝　　　《_,/_｝

      ");



      Console.WriteLine("Welcome to your new adventure! What is your name?");
      string name = Console.ReadLine();
      Console.Clear();
      Player newPlayer = new Player(name);
    }

  }
}
