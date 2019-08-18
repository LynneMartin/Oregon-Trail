using System.Collections.Generic;
using OregonTrail.Project.Interfaces;

namespace OregonTrail.Project.Models
{
  public class Item : IItem
  {
    public string Name { get; set; }
    public string Description { get; set; }
  }
}