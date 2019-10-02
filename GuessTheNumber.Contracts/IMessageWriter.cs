using System;

namespace GuessTheNumber.Contracts
{
    public interface IMessageWriter
    {
        void WriteMessage(string message, ConsoleColor? colour = null);
    }
}
