using System;

namespace TerminalRPG.classes
{
    public abstract class GamePlay
    {
        public virtual int GetUserInput(string prompt = null)
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