using System.Collections.Generic;
using OregonTrail.Project.Models;

namespace OregonTrail.Project.Interfaces
{
    public interface IPlayer
    {
        string PlayerName { get; set; }
        List<Item> Inventory { get; set; }
    }
}

//NOTE I don't think anything more needs to be done on this page