//NOTE This file is the equivalent of an App.cs file

using System.Collections.Generic;
using OregonTrail.Project.Interfaces;
using OregonTrail.Models;

namespace OregonTrail.Project
{
    public class GameService : IGameService
    {
        public Location CurrentLocation { get; set; }

    private bool Running { get; set; } = true;

    //NOTE Creates all data and relationships

    public void Startup()
    {
        //Create all rooms/States
        
    }
  }
}