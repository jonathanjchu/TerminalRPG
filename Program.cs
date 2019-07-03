using System;
using System.Collections.Generic;
using System.Linq;
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

            while (heroes.Exists(x => x.Health > 0) ||
                location.NextLocations.Count == 0 && location.Enemies.Count == 0)
            {
                var ex = new Explore(location);

                if (location.Enemies.Count > 0)
                {
                    var e = new Encounter(heroes, location.Enemies);
                    e.Battle();
                }

                if (location.NextLocations.Count == 0)
                {
                    break;
                }

                location = ex.Move();
            }

            System.Console.WriteLine("Game Over...");
        }
    }
}
