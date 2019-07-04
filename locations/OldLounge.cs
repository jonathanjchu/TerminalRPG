using System;
using System.Collections.Generic;
using TerminalRPG.characters.enemies;
using TerminalRPG.interactions;

namespace TerminalRPG.locations
{
    public class OldLounge : Room
    {
        public OldLounge()
        {
            this.Name = "OldLounge";

            this.Interactions = new List<IInteractable>()
            {

            };

            this.Enemies = new List<Enemy>()
            {

            };

            this.NextLocations = new List<ILocation>()
            {
                
            };
        }

        public override void EnterRoom()
        {
            System.Console.WriteLine("You now find yourself in a strange, decrepit room. It seems somewhat familiar, but you're not sure");
            System.Console.WriteLine("The room is covered in dust and cobwebs. Furniture is ripped apart and strewn across the floor.");
        }
    }
}