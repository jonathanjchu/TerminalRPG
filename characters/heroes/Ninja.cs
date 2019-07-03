using System;
using System.Collections.Generic;
using TerminalRPG.characters;

namespace TerminalRPG.characters.heroes
{

    public class Ninja : Human
    {
        private Random rng;
        public Ninja()
        : base("Ninja")
        {
            rng = new Random();
            this.Dexterity = 5;
        }

        public override int Attack(ICharacter target)
        {
            var dmg = this.Dexterity * 5;
            if (rng.Next(5) == 0)
            {
                dmg += 10;
            }
            target.Health -= dmg;
            return dmg;
        }

        public int Steal(ICharacter target)
        {
            var dmg = 5;
            target.Health -= dmg;
            this.Health += dmg;
            return dmg;
        }

        public override List<CharAction> GetOptions()
        {          
            var options = new List<CharAction>();

            options.Add(new CharAction("Attack", x => this.Attack(x), true));
            options.Add(new CharAction("Steal", x => this.Steal(x), false));
            options.Add(new CharAction("Nothing", x => 0, true));

            return options;
        }   
    }
}