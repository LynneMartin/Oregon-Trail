using System.Collections.Generic;
using OregonTrail.Project.Models;

namespace OregonTrail.Project.Interfaces
{
    public interface IItem
    {
        string Name { get; set; }
        string Description { get; set; }
    }
}