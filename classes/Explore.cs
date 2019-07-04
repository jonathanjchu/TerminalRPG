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
            this.room.EnterRoom();
        }

        public ILocation Move()
        {

            room.GetOptions();
            return room.MakeChoice();
        }        
    }
}