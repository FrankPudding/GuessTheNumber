using GuessTheNumber.Classes;
using GuessTheNumber.Externals;

namespace GuessTheNumberConsoleApp
{
    class Program
    {
        static void Main()
        {
            var userInputReader = new UserInputReader();
            var messageWriter = new MessageWriter();
            var messageProvider = new MessageProvider();
            var guessValidator = new GuessValidator();
            var guessEvaluator = new GuessEvaluator();

            var game = new Game(userInputReader, messageWriter, messageProvider, guessValidator, guessEvaluator);

            game.Play();
        }
    }
}