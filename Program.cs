using System;
using System.Collections.Generic;
using TerminalRPG.classes;
using TerminalRPG.characters;
using TerminalRPG.characters.enemies;
using TerminalRPG.characters.heroes;

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

            var enemies = new List<Enemy>()
            {
                new Spider(),
                new Zombie()
            };

            var game = new Encounter(heroes, enemies);

            game.BattleLoop();
        }
    }
}
