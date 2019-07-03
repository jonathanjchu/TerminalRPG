using System;
using System.Collections.Generic;
using TerminalRPG.characters.enemies;

namespace TerminalRPG.locations
{
    public interface ILocation
    {
        string Name { get; }
        List<string> Interactions { get; }
        List<ILocation> NextLocations { get; }
        List<Enemy> Enemies { get; }
        
        void GetOptions();
    }
}