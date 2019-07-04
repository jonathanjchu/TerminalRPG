namespace TerminalRPG.interactions
{
    public class Sign : IInteractable
    {
        private string _description;

        public string Name { get; private set; }
    

        public Sign()
        {
            this.Name = "Sign";
            this._description = "The sign is just gibberish";
        }

        public Sign(string message)
        {
            this.Name = "Sign";
            this._description = message;
        }

        public void Interact()
        {
            System.Console.WriteLine(this._description);
        }
    }
}