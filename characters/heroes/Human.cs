using System;
using System.Collections.Generic;
using TerminalRPG.characters;


namespace TerminalRPG.characters.heroes
{
    public abstract class Human : ICharacter
    {
        public string Name { get; protected set; }
        public int Strength { get; protected set; }
        public int Intelligence { get; protected set; }
        public int Dexterity { get; protected set; }

        public int Health { get; set; }

        private int Exmaple { get; set; }


        public Human()
        {
            this.Strength = 3;
            this.Intelligence = 3;
            this.Dexterity = 3;
            this.Health = 100;
        }

        public Human(string name)
        {
            this.Name = name;
            this.Strength = 3;
            this.Intelligence = 3;
            this.Dexterity = 3;
            this.Health = 100;
        }

        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            this.Name = name;
            this.Strength = strength;
            this.Intelligence = intelligence;
            this.Dexterity = dexterity;
            this.Health = health;
        }

        public virtual int Attack(ICharacter target)
        {
            var dmg = this.Strength * 5;
            target.Health -= dmg;
            return dmg;
        }

        public virtual void IncreaseStr(int amount)
        {
            this.Strength += amount;
        }

        public virtual void IncreaseInt(int amount)
        {
            this.Intelligence += amount;
        }

        public virtual void IncreaseDex(int amount)
        {
            this.Dexterity += amount;
        }

        public abstract List<CharAction> GetOptions();

    }


}