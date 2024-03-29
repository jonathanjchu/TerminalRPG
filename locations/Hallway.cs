using System;
using System.Collections.Generic;
using TerminalRPG.characters.enemies;
using TerminalRPG.interactions;

namespace TerminalRPG.locations
{
    public class Hallway : Room
    {

        public Hallway()
        {
            this.Name = "Hallway";

            this.Interactions = new List<IInteractable>();

            this.Enemies = new List<Enemy>()
            {
                new Spider(),
                new Zombie()
            };

            this.NextLocations = new List<ILocation>()
            {
                new Classroom()
            };
        }

        public override void EnterRoom()
        {
            System.Console.WriteLine("A long hallway extends out into the darkness.");
        }
    }
}