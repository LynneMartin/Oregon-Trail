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
    private bool Running { get; set; } = true;
    IRoom IGameService.CurrentRoom { get; set; }
    public Player CurrentPlayer { get; set; }

    public GameService(Player player)
    {
      CurrentPlayer = player;
      Setup(); //connected to Program.cs
    }

    //NOTE Creates all data and relationships

    public void Startup()
    {
      //Create all rooms/States
      //   Room missouri = new Room("Missouri"); //starting point REVIEW is this needed?
      //   Room nebraska = new Room("Nebraska"); //Room 1
      //   Room wyoming = new Room("Wyoming"); //Room 2
      //   Room idaho = new Room("Idaho"); //Room 3
      //   Room oregon = new Room("Oregon"); //Room 4, final room

      //   //Establish Relationships
      //   nebraska.AddLocation("next", wyoming);
      //   wyoming.AddLocation("next", idaho);
      //   idaho.AddLocation("next", oregon);
    }
    //NOTE Runs GameService
    public void Run()
    {

    }

    public void Setup()
    {

    }

    public void Reset()
    {
      Running = false;
      Setup();
      StartGame();
    }

    public void StartGame()
    {
      Setup();
      {
        Console.WriteLine("It's a risky, but potentially rewarding adventure that awaits! Can you guide this family to safety?");
        Console.WriteLine("Please give me your first name, my friend.");
        var name = Console.ReadLine();
        CurrentPlayer = new Player(name);
      }
    }

    public void GetUserInput()
    {
      Console.WriteLine($"What's your pleasure, {CurrentPlayer.PlayerName} ?");
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
          System.Console.WriteLine("Command not recognized. Please type HELP and enter for options, or try new command.");
      }
    }
    public void Quit()
    {
      Console.WriteLine(@" 
     __ _        _     __       _  _  _ ___    __ _  | 
    (_ / \   |  / \|\|/__      |_)|_||_) | |\||_ |_) | 
    __)\_/   |__\_/| |\_| /    |  | || \ | | ||__| \ o ");
      Running = false;
    }

    public void Help()
    {
      // print direction options
      Console.WriteLine(@"
      -To move through the game, use the 'go' Command. For example, 'go north', 'go west', etc. 
      -Type 'inventory' for a list of items you have available to use to overcome a challenge. 
      -Type 'use'+item name to use an item in your inventory. 
      -Type 'look' to see what items are available to you in your current location. -Type 'take' if you wish to add it to your inventory of supplies for the trip ahead. 
      -To leave the game, type 'quit.'
      -Press enter to go back to the game. 
      ");
      Console.ReadLine();
    }

    public void Go(string direction)
    {
      Console.Clear();
      if (CurrentRoom.Exits.ContainsKey(direction))
      {
        CurrentRoom = (Room)CurrentRoom.Exits[direction];
      }
      else
      {
        Console.WriteLine("This way is blocked. Choose a different direction.");
      }
    }
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

    public void UseItem(string itemName)
    {
      Item item = CurrentPlayer.Inventory.Find(Item => Item.Name.ToLower() == itemName);
    }

    public void Inventory()
    {
      Console.WriteLine($"Inventory for {CurrentPlayer.PlayerName}: ");
      foreach (var item in CurrentPlayer.Inventory)
      {
        Console.WriteLine(item.Name);
      }
    }

    public void Look()
    {
      Console.Clear();
      Console.WriteLine($"Location: {CurrentRoom.Name}, {CurrentRoom.Description}");
    }
  }
}
