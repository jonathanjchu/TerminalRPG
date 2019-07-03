using System;
using System.Collections.Generic;
using TerminalRPG.classes;
using TerminalRPG.characters;
using TerminalRPG.characters.enemies;
using TerminalRPG.characters.heroes;
using TerminalRPG.locations;

namespace TerminalRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            var heroes = new List<Human>()
            {
                new Ninja(),
                new Samurai(),
                new Wizard()
            };

            ILocation location = new Lobby();

            if (location.Enemies.Count > 0)
            {
                var e = new Encounter(heroes, location.Enemies);
                e.Battle();
            }

            

        }
    }
}
