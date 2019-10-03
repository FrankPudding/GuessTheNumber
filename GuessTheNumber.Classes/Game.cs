using GuessTheNumber.Contracts;
using System;

namespace GuessTheNumber.Classes
{
    public class Game
    {
        private readonly IUserInputReader _userInputReader;
        private readonly IMessageWriter _messageWriter;
        private readonly MessageProvider _messageProvider;
        private readonly GuessValidator _guessValidator;
        private readonly GuessEvaluator _guessEvaluator;

        public Game(IUserInputReader userInputReader, IMessageWriter messageWriter, MessageProvider messageProvider, GuessValidator guessValidator, GuessEvaluator guessEvaluator)
        {
            _userInputReader = userInputReader;
            _messageWriter = messageWriter;
            _messageProvider = messageProvider;
            _guessValidator = guessValidator;
            _guessEvaluator = guessEvaluator;
        }

        public void Play()
        {
            // Title
            _messageWriter.WriteMessage(_messageProvider.Title());

            var random = new Random();
            var currentGuess = new Guess(0, 0, 0);
            bool playing = true;
            int newGuessNumber;
            string inputKey;

            while (playing)
            {
                // Create a random target
                currentGuess.StartGame(random.Next(1000) + 1);

                _messageWriter.WriteMessage(_messageProvider.InitiateGame());
                //_messageWriter.WriteLine(currentGuess.Target.ToString());

                // Keep looping until guess is correct
                while (!_guessEvaluator.IsCorrect(currentGuess))
                {

                    var input = _userInputReader.UserInput();

                    // Loop until input is valid
                    while (!_guessValidator.TryValidate(input, out newGuessNumber))
                    {
                        _messageWriter.WriteMessage(_messageProvider.InvalidGuess(), ConsoleColor.Red);
                        input = _userInputReader.UserInput();
                    }

                    // Update guess with new guess
                    currentGuess.UpdateGuess(newGuessNumber);

                    // Evaluate whether guess is correct
                    if(_guessEvaluator.IsCorrect(currentGuess))
                    {
                        _messageWriter.WriteMessage(_messageProvider.EvaluatorCorrect(currentGuess.NumberOfGuesses), ConsoleColor.Green);
                    }

                    // Evaluate whether guess is too high
                    else if(_guessEvaluator.IsTooHigh(currentGuess))
                    {
                        _messageWriter.WriteMessage(_messageProvider.EvaluatorTooHigh(_guessEvaluator.IsClose(currentGuess)));
                    }

                    // Guess must be too low
                    else
                    {
                        _messageWriter.WriteMessage(_messageProvider.EvaluatorTooLow(_guessEvaluator.IsClose(currentGuess)));
                    }
                }

                _messageWriter.WriteMessage(_messageProvider.PlayAgain());

                inputKey = _userInputReader.UserInputKey();

                if (inputKey != "y" && inputKey != "Y")
                {
                    playing = false;
                    _messageWriter.WriteMessage(_messageProvider.GameOver());
                    _userInputReader.UserInputKey();
                }
            }
        }
    }
}
