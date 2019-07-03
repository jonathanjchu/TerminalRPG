using System;
using System.Collections.Generic;
using TerminalRPG.characters;
using TerminalRPG.characters.enemies;
using TerminalRPG.characters.heroes;

namespace TerminalRPG.classes
{
    public class Encounter
    {
        private Random _rng;

        public List<Human> Heroes { get; private set; }
        public List<Enemy> Enemies { get; private set; }

        public Encounter(List<Human> heroes, List<Enemy> enemies)
        {
            this.Heroes = heroes;
            this.Enemies = enemies;
            this._rng = new Random();
        }

        public void BattleLoop()
        {
            while (this.Enemies.Count > 0 && this.Heroes.Count > 0)
            {
                HeroesTurn();

                System.Console.WriteLine();

                EnemiesTurn();

                System.Console.WriteLine();
            }

            if (this.Heroes.Count > 0 && this.Enemies.Count == 0)
            {
                System.Console.WriteLine("Victory!");
            }
            else if (this.Heroes.Count == 0 && this.Enemies.Count > 0)
            {
                System.Console.WriteLine("You Lose...");
            }
        }

        private void HeroesTurn()
        {
            foreach (var hero in this.Heroes)
            {
                // show options and get user's choice
                var options = hero.GetOptions();
                System.Console.WriteLine($"{hero.Name} - choose an action:");
                ShowOptions(options);
                int choice = GetUserInput();

                if (choice >= 0 && choice < options.Count)
                {
                    System.Console.WriteLine("Choose target:");

                    if (options[choice].isTargetEnemy)
                    {
                        ListEnemies();
                        var target = GetUserInput();
                        if (target >= 0 && target < this.Enemies.Count)
                        {
                            var dmg = options[choice].Action(this.Enemies[target]);

                            System.Console.WriteLine($"{hero.Name} attacks and deals {dmg} damage to {this.Enemies[target].Name}");
                            System.Console.WriteLine($"{this.Enemies[target].Name} is at {this.Enemies[target].Health} HP");

                            if (this.Enemies[target].Health <= 0)
                            {
                                System.Console.WriteLine($"{this.Enemies[target].Name} killed");
                                this.Enemies.RemoveAt(target);
                                if (this.Enemies.Count == 0)
                                    return;
                            }
                        }
                        else
                        {
                            System.Console.WriteLine($"{hero.Name} is confused and {options[choice].Name}s nothing");
                        }
                    }
                    else
                    {
                        ListHeroes();

                        var target = GetUserInput();
                        if (target >= 0 && target < this.Heroes.Count)
                        {
                            var heal = options[choice].Action(this.Heroes[target]);

                            System.Console.WriteLine($"{hero.Name} heals {this.Heroes[target].Name} for {heal} HP");
                            System.Console.WriteLine($"{this.Heroes[target].Name} is now at {this.Heroes[target].Health} HP");
                        }
                        else
                        {
                            System.Console.WriteLine($"{hero.Name} is confused and {options[choice].Name}s nothing");
                        }
                    }
                }
                else
                {
                    System.Console.WriteLine($"{hero.Name} is confused and does nothing");
                }
            }
        }

        private void EnemiesTurn()
        {
            foreach (var enemy in this.Enemies)
            {
                var target = this.Heroes[this._rng.Next(this.Heroes.Count)];
                var dmg = enemy.Attack(target);
                System.Console.WriteLine($"{enemy.Name} attacks and deals {dmg} damage to {target.Name}");
                System.Console.WriteLine($"{target.Name} is now at {target.Health} HP");

                if (target.Health <= 0)
                {
                    System.Console.WriteLine($"{target.Name} dies");
                    this.Heroes.Remove(target);

                    if (this.Heroes.Count == 0)
                        return;
                }
            }
        }

        public void ListEnemies()
        {
            for (var i = 0; i < this.Enemies.Count; i++)
            {
                System.Console.WriteLine($"{i + 1}. {this.Enemies[i].Name}");
            }
        }

        public void ListHeroes()
        {
            for (var i = 0; i < this.Heroes.Count; i++)
            {
                System.Console.WriteLine($"{i + 1}. {this.Heroes[i].Name}");
            }
        }

        private void ShowOptions(List<CharAction> options)
        {
            for (var i = 0; i < options.Count; i++)
            {
                System.Console.WriteLine($"{i + 1}. {options[i].Name}");
            }
        }

        public int GetUserInput(string prompt = null)
        {
            string input = string.Empty;
            int result;

            if (!String.IsNullOrEmpty(prompt))
            {
                System.Console.WriteLine(prompt + ":");
            }
            input = System.Console.ReadLine();

            int.TryParse(input, out result);
            return result - 1;
        }
    }
}