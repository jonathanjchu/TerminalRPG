using TerminalRPG.characters;

namespace TerminalRPG.interactions
{
    public interface IInteractable
    {
        string Name { get; }

        void Interact();
    }
}