// using System;
using System;
using System.Collections.Generic;
using OregonTrail.Project.Interfaces;

namespace OregonTrail.Project.Models
{
  public class Room : IRoom
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Item> Items { get; set; }
    public Dictionary<string, IRoom> Exits { get; set; }

    public void AddExit(string direction, IRoom room)
    {
      Exits.Add(direction, room);
    }

    
public Room(string name, string description)
    {
      Name = name;
      Description = description;
      Items = new List<Item>();
      Exits = new Dictionary<string, IRoom>();
    }

    public IRoom Go(string direction)
    {
      if (Exits.ContainsKey(direction))
      {
        return Exits[direction];
      }
      Console.WriteLine("Not that way.");
      return this;
    }
  }
}