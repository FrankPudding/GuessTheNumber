using System;
using GuessTheNumber.Contracts;

namespace GuessTheNumber.Externals
{
    public class MessageWriter : IMessageWriter
    {
        public void WriteMessage(string message, ConsoleColor? colour = null)
        {
            if(colour.HasValue)
            {
                Console.ForegroundColor = colour.Value;
            }
            else
            {
                Console.ResetColor();
            }

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
