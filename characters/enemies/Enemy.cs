using System;
using TerminalRPG.characters;

namespace TerminalRPG.characters.enemies
{
    public abstract class Enemy : ICharacter
    {
        public Enemy()
        {
            this.Health = 80;
        }

        public string Name { get; protected set; }
        public int Health { get; set; }
        public int Strength { get; set; }


        public virtual int Attack(ICharacter target)
        {
            var dmg = this.Strength * 5;
            target.Health -= dmg;

            System.Console.WriteLine($"{this.Name} attacks {target.Name} and deals {dmg} damage");
            System.Console.WriteLine($"{target.Name} is now at {target.Health} HP");

            return dmg;
        }
    }
}