using System;
using TerminalRPG.locations;

namespace TerminalRPG.classes
{
    public class Explore : GamePlay
    {
        private ILocation room;

        public Explore(ILocation room)
        {
            this.room = room;
        }

        public ILocation Move()
        {

            GetOptions();
            int choice = GetUserInput();

            if (choice >= 0 && choice < room.NextLocations.Count)
            {
                return room.NextLocations[choice];
            }
            else
            {
                return this.room;
            }
        }

        public void GetOptions()
        {
            for (var i = 0; i < room.NextLocations.Count; i++)
            {
                System.Console.WriteLine($"{i+1}. {room.NextLocations[i].Name}");
            }
        }

        
    }
}