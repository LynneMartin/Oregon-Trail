using System.Collections.Generic;
using OregonTrail.Project.Models;

namespace OregonTrail.Project.Interfaces
{
    public interface IRoom
    {
        string Name { get; set; }
        string Description { get; set; }
        List<Item> Items { get; set; }
        Dictionary<string, IRoom> Exits { get; set; }
    }
}

//NOTE I don't think anything more needs to be done on this page
