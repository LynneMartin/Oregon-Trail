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
  }
}