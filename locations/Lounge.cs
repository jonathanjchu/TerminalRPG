using System;
using System.Collections.Generic;
using TerminalRPG.characters.enemies;
using TerminalRPG.interactions;

namespace TerminalRPG.locations
{
    public class Lounge : Room
    {
        public Lounge()
        {
            this.Name = "Lounge";

            this.Interactions = new List<IInteractable>()
            {

            };

            this.Enemies = new List<Enemy>()
            {

            };

            this.NextLocations = new List<ILocation>()
            {
                new OldLounge()
            };
        }

        public override void EnterRoom()
        {
            System.Console.WriteLine("You decide to take a nice long nap on the couch!");
            System.Console.WriteLine("Zzz...");
            System.Console.WriteLine("ZZZZZzzzzzzzz.............");
            System.Console.WriteLine("(pree any key to wake up)");
            Console.ReadKey();
        }

        public override void GetOptions()
        {

        }

        public override ILocation MakeChoice()
        {
            return new OldLounge();
        }
    }
}