using GuessTheNumber.Contracts;
using System;

namespace GuessTheNumber.Externals
{
    public class UserInputReader : IUserInputReader
    {
        public string UserInput()
        {
            return Console.ReadLine();
        }

        public string UserInputKey()
        {
            return Console.ReadKey().KeyChar.ToString();
        }
    }
}
