namespace TerminalRPG.characters
{
    public interface ICharacter
    {
        string Name { get; }
         int Health { get; set; }

         int Attack(ICharacter target);
    }
}