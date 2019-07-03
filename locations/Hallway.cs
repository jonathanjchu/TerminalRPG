using System;
using System.Collections.Generic;
using TerminalRPG.characters.enemies;

namespace TerminalRPG.locations
{
    public class Hallway : ILocation
    {
        public string Name { get; private set; }

        public string Description { get; private set; }

        public List<string> Interactions { get; private set; }

        public List<ILocation> NextLocations { get; private set; }

        public List<Enemy> Enemies { get; private set; }

        public Hallway()
        {
            this.Name = "Hallway";
            this.Description = "A long hallway extends out into the darkness.";

            this.Enemies = new List<Enemy>()
            {
                new Zombie(),
                new Zombie()
            };

            this.NextLocations = new List<ILocation>()
            {

            };
        }

        public void GetOptions()
        {

        }
    }
}