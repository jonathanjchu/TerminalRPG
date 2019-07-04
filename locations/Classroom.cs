using System;
using System.Collections.Generic;
using TerminalRPG.characters.enemies;
using TerminalRPG.interactions;

namespace TerminalRPG.locations
{
    public class Classroom : Room
    {
        public Classroom()
        {
            this.Name = "Classroom";

            this.Interactions = new List<IInteractable>();

            this.Enemies = new List<Enemy>()
            {
                new Algos(),
                new Algos()
            };

            this.NextLocations = new List<ILocation>()
            {
                new Kitchen(),
                new Lounge()
            };
        }

        public override void EnterRoom()
        {
            System.Console.WriteLine("There are rows after rows of desks, but not much seems to be going on here.");
        }
    }
}