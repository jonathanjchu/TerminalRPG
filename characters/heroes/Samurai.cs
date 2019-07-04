using System;
using System.Collections.Generic;
using TerminalRPG.characters;

namespace TerminalRPG.characters.heroes
{

    public class Samurai : Human
    {
        public Samurai()
        : base("Samurai")
        {
            this.Health = 200;
        }

        public override int Attack(ICharacter target)
        {
            var dmg = base.Attack(target);

            if (target.Health < 30)
            {
                dmg += target.Health;
                target.Health = 0;
                System.Console.WriteLine($"{this.Name} executes {target.Name}");
            }

            return dmg;
        }

        public int Meditate()
        {
            var heal = 200 - this.Health;
            this.Health = 200;

            System.Console.WriteLine($"{this.Name} meditates and heals by {heal} HP");
            System.Console.WriteLine($"{this.Name} is now at {this.Health} HP");

            return heal;
        }

        public override List<CharAction> GetOptions()
        {
            var options = new List<CharAction>();

            options.Add(new CharAction("Attack", x => this.Attack(x), true));
            options.Add(new CharAction("Meditate", x => this.Meditate(), null));
            options.Add(new CharAction("Nothing", x => 0, null));

            return options;
        }
    }
}