namespace GuessTheNumber.Classes
{
    public class GuessEvaluator
    {
        public bool IsCorrect(Guess guess)
        {
            return guess.GuessNumber == guess.Target;
        }

        public bool IsTooHigh(Guess guess)
        {
            return guess.GuessNumber > guess.Target;
        }

        public bool IsClose(Guess guess)
        {
            return guess.GuessNumber - guess.Target < 10 && guess.Target - guess.GuessNumber < 10;
        }
    }
}
