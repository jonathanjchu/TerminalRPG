using System;

namespace TerminalRPG.characters
{
    public class CharAction
    {
        public string Name { get; set; }
        public Func<ICharacter, int> Action { get; set; }
        public bool? isTargetEnemy { get; set; }

        public CharAction(string name, Func<ICharacter, int> action, bool? isTargetEnemy)
        {
            this.Name = name;
            this.Action = action;
            this.isTargetEnemy = isTargetEnemy;
        }

    }
}