using System;
using TerminalRPG.characters;

namespace TerminalRPG.characters.enemies
{
    public class Zombie : Enemy
    {
        public Zombie()
        {
            this.Name = "Zombie";
            this.Strength = 4;
        }
    }
}