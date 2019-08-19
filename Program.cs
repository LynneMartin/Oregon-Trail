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

      ")



      Console.WriteLine("Welcome to the Oregon Trail! Press enter to begin.");
      Console.ReadKey(); //press any key to continue
    }

  }
}
