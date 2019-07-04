using System.Collections.Generic;
using TerminalRPG.characters.enemies;
using TerminalRPG.interactions;

namespace TerminalRPG.locations
{
    public class Kitchen : Room
    {
        public Kitchen() : base()
        {
            this.Name = "Kitchen";
            
            this.Interactions = new List<IInteractable>()
            {
                new Sign("No more food, you pigs!")
            };

            this.Enemies = new List<Enemy>()
            {

            };

            this.NextLocations = new List<ILocation>()
            {
                // new Classroom(),
                new Lounge()
            };
        }

        public override void EnterRoom()
        {
            System.Console.WriteLine("The kitchen stocked full of snacks and candy.");
        }

        
    }
}