namespace GuessTheNumber.Classes
{
    public class MessageProvider
    {
        public string Title()
        {
            return "GUESS THE NUMBER";
        }

        public string InitiateGame()
        {
            return $"\nI am thinking of a number betweeen 1 and 1000, can you guess what it is?";
        }

        public string PlayAgain()
        {
            return "\npress 'y' to play again - any other key will end the game";
        }

        public string GameOver()
        {
            return "\nGAME OVER";
        }

        public string InvalidGuess()
        {
            return $"That is not a valid guess - Try again";
        }

        public string EvaluatorCorrect(int numberOfGuesses)
        {
            return $"\nWell done, that is correct! You took {numberOfGuesses} {((numberOfGuesses == 1) ? "guess" : "guesses")}";
        }

        public string EvaluatorTooHigh(bool isClose)
        {
            return $"That is too high - Try again {(isClose ? EvaluatorIsClose() : "")}";
        }

        public string EvaluatorTooLow(bool isClose)
        {
            return $"That is too low - Try again {(isClose ? EvaluatorIsClose() : "")}";
        }

        public string EvaluatorIsClose()
        {
            return "(You are getting close)";
        }
    }
}
