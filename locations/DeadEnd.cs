using System.Collections.Generic;
using TerminalRPG.characters.enemies;
using TerminalRPG.interactions;

namespace TerminalRPG.locations
{
    public class DeadEnd : ILocation
    {
        public string Name { get; private set; }

        public List<IInteractable> Interactions { get; private set; }

        public List<ILocation> NextLocations { get; private set; }

        public List<Enemy> Enemies { get; private set; }

        public DeadEnd()
        {
            
        }

        public void EnterRoom()
        {
            throw new System.NotImplementedException();
        }

        public void GetOptions()
        {
            throw new System.NotImplementedException();
        }

        public ILocation MakeChoice()
        {
            throw new System.NotImplementedException();
        }
    }
}