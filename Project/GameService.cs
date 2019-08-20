//NOTE This file is the equivalent of an App.cs file
using System;
using System.Collections.Generic;
using OregonTrail.Project.Interfaces;
using OregonTrail.Project.Models;

namespace OregonTrail.Project
{
  public class GameService : IGameService
  {
    public bool Running { get; set; } = true; //GameService running
    public IRoom CurrentRoom { get; set; }
    public Player CurrentPlayer { get; set; }

    // ========================== START GAME ============================
    public void Startup() //NOTE WORKS!
    {
      Setup();
    }
    // ========================== RUN ============================

    //NOTE Runs GameService
    public void Run()
    {
    
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
        Console.WriteLine("We begin this long journey from Independence, Missouri.");
        Console.WriteLine("The first State you enter ahead is Nebraska heading West.");
        Console.WriteLine("Type 'go west' to be taken there now.");

        while (Running)
        {
          GetUserInput(); //NOTE WORKS!
        }
      }
    }
    // ========================== SETUP ============================

    public void Setup() //NOTE WORKS!
    {
      Running = true;

      Room missouri = new Room("Missouri", "Starting point."); //take in a name and description
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

      missouri.Exits.Add("west", nebraska); //NOTE talks to Room constructor in Room.cs. Starting point.

      nebraska.Exits.Add("west", wyoming);
      nebraska.Exits.Add("east", missouri); // back to starting point
      nebraska.Exits.Add("south", escape); //GAME OVER
      nebraska.Items.Add(Gunpowder); //Needed to trade with friendlier Natives.

      wyoming.Exits.Add("west", idaho);
      wyoming.Exits.Add("south", mercantile); //You'll avoid starvation
      wyoming.Exits.Add("east", nebraska); 
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

      CurrentRoom = missouri; //NOTE starting point

    }
    

    // ========================== GET USER INPUT ============================

    public void GetUserInput()
    {
      //REVIEW referenced in planet-express example. Please 'splain?
      string[] input = Console.ReadLine().ToLower().Split(' '); //input = ['go', 'north']
      string command = input[0]; //command = 'go'
      string option = "";
      if (input.Length > 1)
      {
        option = input[1]; 
      }
      
      switch(command)
      {
        case "go":
          Go(option);
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
          Quit(); //REVIEW is this necessary if I have Running = false below?
          Running = false;
          break;
        default: 
          System.Console.WriteLine("Command not recognized. Please type HELP for options, or try valid command.");
          break;
      }
    }
    // ========================== RESET ============================
    public void Reset() //NOTE WORKS!
    {
      StartGame();
    }

    // ========================== QUIT ============================

    public void Quit() //NOTE WORKS!
    {
      Console.Clear();
      Console.WriteLine(@" 
     __ _        _     __       _  _  _ ___    __ _  | 
    (_ / \   |  / \|\|/__      |_)|_||_) | |\||_ |_) | 
    __)\_/   |__\_/| |\_| /    |  | || \ | | ||__| \ o ");
      Running = false; //stops the game
    }
    // ========================== HELP ============================
    public void Help() //NOTE WORKS, except "enter to go back to the game"!
    {
      // Console.Clear();
      Console.WriteLine(@"
      -To move through the game, use the 'go' Command. For example, 'go north', 'go west', etc. 

      -Type 'inventory' for a list of items you have available to use to overcome a challenge. 

      -Type 'use'+item name to use an item in your inventory. 

      -Type 'look' to see what items are available to you in your current location. 
      
      -Type 'take' if you wish to add it to your inventory of supplies for the trip ahead. 

      -To leave the game, type 'quit.'

      -Press enter to go back to the game. 
      ");
      Console.ReadLine(); //FIXME Should the command be "exit" or "done" to go back to current room instead of the act of pressing the enter button? I couldn't figure out how to get this last help command working with 'enter'.
    }

    // ========================== GO ============================
    public void Go(string direction)
    {
      Console.Clear();
      if (CurrentRoom.Exits.ContainsKey(direction))
      {
        CurrentRoom = CurrentRoom.Exits[direction];
      }
      else
      {
        Console.WriteLine("This way is blocked. Choose a different direction.");
      }
    }

    // ========================== TAKE ITEM ============================

    public void TakeItem(string itemName) 
      {
      Item item = CurrentRoom.Items.Find(Item => Item.Name.ToLower() == itemName);
      if (item != null) 
      {
        Console.WriteLine($"You have {item.Description} available to take with you.");
        CurrentRoom.Items.Remove(item); //take an available item from a room
        CurrentPlayer.Inventory.Add(item); //add it to my inventory, in this order
      }
      else
      {
        Console.WriteLine("Invalid request. Type 'help' or try again.");
      }
    }
    // ========================== USE ITEM ============================

    public void UseItem(string itemName)
    {
      Item item = CurrentPlayer.Inventory.Find(Item => Item.Name.ToLower() == itemName);
      if (item != null)
      {
        CurrentPlayer.Inventory.Remove(item);
        Console.WriteLine("Item successfully used. Carry on!");
      }
      else
      {
        Console.WriteLine("Item not available.");
      }

    }
    // ========================== INVENTORY ============================
    public void Inventory() 
    {
      Console.WriteLine($"Current inventory for {CurrentPlayer.PlayerName}: ");
      foreach (var item in CurrentPlayer.Inventory) //iterates over each item in the player's inventory
      {
        Console.WriteLine($"{ item.Name}");
      }
    }
    // ========================== LOOK ============================

    public void Look() 
    {
      Console.WriteLine($"{CurrentRoom.Description}"); 
      //TODO show items in the current room with a count, probably using a for loop
    }
  }
}

//TODO Need a win & lose 
