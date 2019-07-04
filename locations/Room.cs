using System;
using System.Collections.Generic;
using TerminalRPG.characters.enemies;
using TerminalRPG.interactions;

namespace TerminalRPG.locations
{
    public abstract class Room : ILocation
    {

        public string Name { get; protected set; }

        public string Description { get; protected set; }

        public List<IInteractable> Interactions { get; protected set; }

        public List<ILocation> NextLocations { get; protected set; }

        public List<Enemy> Enemies { get; protected set; }

        public Room()
        {
        }

        public abstract void EnterRoom();

        public virtual void GetOptions()
        {
            System.Console.WriteLine("Items:");
            foreach (var item in this.Interactions)
            {
                System.Console.WriteLine(item.Name);
            }
            System.Console.WriteLine();

            System.Console.WriteLine("Locations:");
            foreach (var loc in this.NextLocations)
            {
                System.Console.WriteLine(loc.Name);
            }
        }

        public virtual ILocation MakeChoice()
        {
            string choice = System.Console.ReadLine();

            System.Console.WriteLine("********************************");
            System.Console.WriteLine();
            
            var item = this.Interactions.Find(x => x.Name == choice);
            if (item != null)
            {
                item.Interact();
                System.Console.WriteLine();
                return this;
            }
            else
            {
                var loc = this.NextLocations.Find(x => x.Name == choice);
                if (loc != null)
                {
                    return loc;
                }
                else
                {
                    return this;
                }
            }
        }
    }
}