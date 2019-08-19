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
      throw new System.NotImplementedException();
    }

    public void Reset()
    {
      throw new System.NotImplementedException();
    }

    public void StartGame()
    {
      throw new System.NotImplementedException();
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
      // print direction options, current room/state information
    }

    public void Go(string direction)
    {
      throw new System.NotImplementedException();
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