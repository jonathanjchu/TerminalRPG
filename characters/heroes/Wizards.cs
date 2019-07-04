using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using TerminalRPG.characters;

namespace TerminalRPG.characters.heroes
{

    public class Wizard : Human
    {
        public Wizard()
        : base("Wizard")
        {
            this.Health = 50;
            this.Intelligence = 5;
        }

        public override int Attack(ICharacter target)
        {
            var dmg = this.Intelligence * 5;
            this.Health += dmg;
            target.Health -= dmg;

            System.Console.WriteLine($"{this.Name} attacks {target.Name} and deals {dmg} damage");
            System.Console.WriteLine($"{target.Name} is now at {target.Health} HP");

            return dmg;
        }

        public int Heal(ICharacter target)
        {
            var heal = this.Intelligence * 10;
            target.Health += heal;

            System.Console.WriteLine($"{this.Name} heals {target.Name} for {heal} HP");
            System.Console.WriteLine($"{target.Name} is now at {target.Health} HP");

            return heal;
        }


        public override List<CharAction> GetOptions()
        {
            var options = new List<CharAction>();

            options.Add(new CharAction("Attack", x => this.Attack(x), true));
            options.Add(new CharAction("Heal", x => this.Heal(x), false));

            return options;
        }
    }
}