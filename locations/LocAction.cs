using System;
using TerminalRPG.characters.heroes;

namespace TerminalRPG.locations
{
    public class LocAction
    {
        public string Name { get; set; }
        public Func<ILocation> Action { get; set; }
    }
}