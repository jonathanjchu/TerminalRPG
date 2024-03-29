using System;
using System.Collections.Generic;
using TerminalRPG.characters.enemies;
using TerminalRPG.interactions;

namespace TerminalRPG.locations
{
    public class Lobby : Room
    {

        public Lobby()
        {
            this.Name = "Lobby";

            this.Interactions = new List<IInteractable>()
            {
                new Sign("Welcome to MoonBucks! Come get an overpriced coffee!")
            };

            this.Enemies = new List<Enemy>()
            {
                new Spider()
            };

            this.NextLocations = new List<ILocation>()
            {
                new Hallway()
            };
        }

        public override void EnterRoom()
        {
            System.Console.WriteLine("You enter a large atrium with large windows on one side.");
        }
    }
}