//NOTE This file is the equivalent of an App.cs file
using System;
using System.Collections.Generic;
using OregonTrail.Project.Interfaces;
using OregonTrail.Project.Models;

namespace OregonTrail.Project
{
  public class GameService : IGameService
  {
    public Room CurrentRoom { get; set; }
    public bool Running = true;
    IRoom IGameService.CurrentRoom { get; set; }
    public Player CurrentPlayer { get; set; }

    private bool Playing { get; set; } = true;
    // ========================== START GAME ============================
    public void Startup() //NOTE WORKS!
    {
      
    }
    // ========================== RUN ============================

    //NOTE Runs GameService
    public void Run()
    {
    
    }
    // ========================== SETUP ============================

    public void Setup() //NOTE WORKS!
    {
      Running = true;

      Room missouri = new Room("Missouri", "Starting point.");
      Room nebraska = new Room("Nebraska", "Going Westward, halfway across the plains, a wheel falls apart and you are separated from the wagon train. A group of Natives are spotted to the North approaching your newly-repaired wagon. If you are to get out of this situation alive, you must find something of value to offer them, or attempt to escape. Choose your direction.");
      Room escape = new Room("Escape", "You attempt to escape by heading South, but find yourself trapped by a different band of hostile Native warriors and they show no mercy. YOU DIE A HORRIBLE DEATH. Type 'reset' to start over or 'quit' to end the game.");
      Room wyoming = new Room("Wyoming", "Your family is hungry. Where can you go to find more food supplies? Choose your direction."); //Halfway there, but starvation looms
      Room mercantile = new Room("Mercantile: ", "You've reached a small town with a local Mercantile. You can pick up some beans here to fend off hunger later.");
      Room wilderness = new Room("Wilderness: ", "You headed Northward toward rough terrain, getting lost, losing time, and starve to death. GAME OVER. Type 'reset' to start over or 'quit' to end the game."); //You'll lose too much time and starve to death
      Room idaho = new Room("Idaho", "You're only 8 days away from your destination, but you reach a deep and swift river. Do you try and cross? Or do you try a different way? Choose your direction.");
      Room river = new Room("River: ", "You've reached a wide river that is deceptively deep. You attempt to cross, but are swept away, drowning all. GAME OVER. Type 'reset' to start over or 'quit' to end the game.");
      Room ferry = new Room("Ferry: ", "Just up-river a few miles, you come across a man who offers ferry passage across the river for $2.00. Safe and sound!");
      Room oregon = new Room("Oregon", "You're almost there! You've reached a daunting mountain pass that you must cross before you make it to your new home. Which direction will you take?");
      Room mountains = new Room("Mountain Pass: ", "You've come up to a daunting and dangerous mountain pass. Foolishly, you attempted to cross, but destroyed one of your wheels again. You must fix the wheel. You died of dysentery and your child and mules died of exposure. GAME OVER. Type 'reset' to start over or 'quit' to end the game.");
      Room home = new Room("Oregon City, Oregon:", "Home, sweet home! YOU WIN! Select 'reset' to play again or 'quit' to end game."); //Final Room, YOU WIN!

      Item Gunpowder = new Item("Sack of gunpowder: ", "Desirable trade item.");
      Item Beans = new Item("50-lb bag of beans: ", "Packed with fiber and protein.");
      Item Coins = new Item("Purse of coins: ", "Looks to be approximately $5.00-worth.");
      Item WagonWheel = new Item("Wagon Wheel: ", "Replacement wagon wheel.");

      missouri.Exits.Add("west", nebraska);

      nebraska.Exits.Add("west", wyoming);
      nebraska.Exits.Add("east", missouri); // back to starting point
      nebraska.Exits.Add("south", escape); //GAME OVER
      nebraska.Items.Add(Gunpowder); //Needed to trade with friendlier Natives.

      wyoming.Exits.Add("west", idaho);
      wyoming.Exits.Add("south", mercantile); //You'll avoid starvation
      wyoming.Exits.Add("east", wyoming); 
      wyoming.Exits.Add("north", wilderness); //GAME OVER
      wyoming.Items.Add(Beans); // Needed to fend of starvation

      idaho.Exits.Add("west", oregon);
      idaho.Exits.Add("east", wyoming);
      idaho.Exits.Add("south", river); //GAME OVER
      idaho.Exits.Add("north", ferry);
      idaho.Items.Add(Coins); // Needed to buy a ferry ride across the river

      oregon.Exits.Add("east", idaho);
      oregon.Exits.Add("north", home); //YOU WIN!
      oregon.Exits.Add("west", mountains); //GAME OVER unless you use a wagon wheel
      oregon.Items.Add(WagonWheel); //Needed to cross the mountains

      CurrentRoom = missouri;

    }
    // ========================== RESET ============================

    public void Reset() //NOTE WORKS!
    {
      StartGame();
    }
    // ========================== START GAME ============================

    public void StartGame() //NOTE WORKS!
    {
      Setup();
      {
        Console.WriteLine(@"
     ___   ___   ____  __    ___   _         _____  ___    __    _   _    
    / / \ | |_) | |_  / /`_ / / \ | |\ |      | |  | |_)  / /\  | | | |   
    \_\_/ |_| \ |_|__ \_\_/ \_\_/ |_| \|      |_|  |_| \ /_/--\ |_| |_|__ ");

        Console.WriteLine("Welcome to your new adventure!");
        Console.WriteLine("Please give me your first name, my friend.");
        var name = Console.ReadLine();
        CurrentPlayer = new Player(name);
//NOTE next lines shown after entering name at start of game
        Console.Clear();
        Console.WriteLine("We begin this long journey from Independence, Missouri."); Console.WriteLine("The first State you enter ahead is Nebraska heading West. Type 'go west' to be taken there now.");

        while (Running)
        {
          GetUserInput(); //NOTE WORKS!
        }
      }
    }
    // ========================== GET USER INPUT ============================

    public void GetUserInput()
    {
      //NOTE next question following "There's no turning back now!" in StartGame
      // Console.WriteLine($"When you're ready to head 'em up and move 'em out, type 'go west' now, {CurrentPlayer.PlayerName}.");
      string UserInput = Console.ReadLine();
      switch (UserInput.ToLower())
      {
        case "go north":
          Go("north");
          break;
        case "go south":
          Go("south");
          break;
        case "go east":
          Go("east");
          break;
        case "go west":
          Go("west");
          break;
        case "look":
          Look();
          break;
        case "inventory":
          Inventory();
          break;
        case "take item":
          TakeItem("take");
          break;
        case "use item":
          UseItem("use");
          break;
        case "help":
          Help();
          break;
        case "reset":
          Reset();
          break;
        case "quit":
          Quit();
          break;
        default: 
          System.Console.WriteLine("Command not recognized. Please type HELP for options, or try valid command.");
          break;
      }
    }
    // ========================== QUIT ============================

    public void Quit() //NOTE WORKS!
    {
      Console.WriteLine(@" 
     __ _        _     __       _  _  _ ___    __ _  | 
    (_ / \   |  / \|\|/__      |_)|_||_) | |\||_ |_) | 
    __)\_/   |__\_/| |\_| /    |  | || \ | | ||__| \ o ");
      Running = false;
    }
    // ========================== HELP ============================
    public void Help() //NOTE WORKS!
    {
      Console.WriteLine(@"
      -To move through the game, use the 'go' Command. For example, 'go north', 'go west', etc. 
      -Type 'inventory' for a list of items you have available to use to overcome a challenge. 
      -Type 'use'+item name to use an item in your inventory. 
      -Type 'look' to see what items are available to you in your current location. -Type 'take' if you wish to add it to your inventory of supplies for the trip ahead. 
      -To leave the game, type 'quit.'
      -Press enter to go back to the game.
      ");
      Console.ReadLine(); //FIXME "Press Enter to go back to the game" not wired up
      Look();
    }

    // ========================== GO ============================

    public void Go(string direction)
    {
      // CurrentRoom = CurrentRoom.Go(direction); //didn't work

      if (CurrentRoom.Exits.ContainsKey(direction))
      {
        CurrentRoom = (Room)CurrentRoom.Exits[direction];
        Look();
      }
      else
      {
        System.Console.WriteLine("Nothing that way."); //FIXME works but causes me problems with using any other direction to continue.
      }

    }
    // ========================== TAKE ITEM ============================

    public void TakeItem(string itemName)
    {
      Item item = CurrentRoom.Items.Find(Item => Item.Name.ToLower() == itemName);
      if (item != null)
      {
        CurrentRoom.Items.Remove(item);
        CurrentPlayer.Inventory.Add(item);
        CurrentPlayer.Inventory.Remove(item);
      }
      else
      {
        Console.WriteLine("You have no items.");
      }
    }
    // ========================== USE ITEM ============================

    public void UseItem(string itemName)
    {
      Item item = CurrentPlayer.Inventory.Find(Item => Item.Name.ToLower() == itemName);
    }
    // ========================== INVENTORY ============================
    public void Inventory() //NOTE works but haven't figured out how to take items to add to the inventory
    {
      Console.WriteLine($"Inventory for {CurrentPlayer.PlayerName}: ");
      foreach (var item in CurrentPlayer.Inventory)
      {
        Console.WriteLine($"{ item.Name}");
      }
    }
    // ========================== LOOK ============================

    public void Look() 
    {
      Console.WriteLine($"{CurrentRoom.Description}");
    }
  }
}
