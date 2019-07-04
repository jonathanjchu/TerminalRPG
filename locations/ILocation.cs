using System;
using System.Collections.Generic;
using TerminalRPG.characters.enemies;
using TerminalRPG.interactions;

namespace TerminalRPG.locations
{
    public interface ILocation
    {
        string Name { get; }
        List<IInteractable> Interactions { get; }
        List<ILocation> NextLocations { get; }
        List<Enemy> Enemies { get; }
        
        void EnterRoom();
        void GetOptions();
        ILocation MakeChoice();
    }
}