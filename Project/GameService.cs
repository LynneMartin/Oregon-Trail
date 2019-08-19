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

    //   CurrentLocation = missouri;
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
    //   Console.WriteLine($"What's your next move, {CurrentPlayer.PlayerName}?");
    //   string UserInput = Console.ReadLine();
    //   switch (UserInput.ToLower())
    }

      public void Quit()
    {
      throw new System.NotImplementedException();
    }

    public void Help()
    {
      // print direction options
      Console.WriteLine("To move through the game, use the 'go' Command. For example, 'go north', 'go west', etc. Type 'inventory' for a list of items you have available to use to overcome a challenge, and type 'use'+item name to use it. Type 'look' to see what items are available to you in the current location. Type 'take' if you wish to add it to your inventory of supplies for the trip ahead. To leave the game, type 'quit.' ");
    }

    public void Go(string direction)
    {
      CurrentRoom = CurrentRoom.Go(direction); //FIXME
    }

    public void TakeItem(string itemName)
    {
      throw new System.NotImplementedException();
    }

    public void UseItem(string itemName)
    {
      throw new System.NotImplementedException();
    }

    public void Inventory()
    {
      throw new System.NotImplementedException();
    }

    public void Look()
    {
      throw new System.NotImplementedException();
    }
  }
}