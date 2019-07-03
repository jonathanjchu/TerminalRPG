using System;
using System.Collections.Generic;
using TerminalRPG.characters.enemies;

namespace TerminalRPG.locations
{
    public class Lobby : ILocation
    {

        public string Name { get; private set; }
        public List<string> Interactions { get; private set; }
        public List<ILocation> NextLocations { get; private set; }
        public List<Enemy> Enemies { get; private set; }

        public Lobby()
        {
            this.Name = "Lobby";

            this.Interactions = new List<string>()
            {

            };

            this.Enemies = new List<Enemy>()
            {
                new Spider(),
                new Zombie()
            };
        }

        public void EnterRoom()
        {
            
        }

        public void GetOptions()
        {
            throw new NotImplementedException();
        }
    }
}