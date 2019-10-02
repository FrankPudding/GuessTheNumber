using System;
using System.Collections.Generic;
using System.Linq;

namespace GuessTheNumber.Classes
{
    public class Guess
    {
        public IList<Guess> GuessList { get; private set; }

        public Guess(int guessNumber, int target, int numberOfGuesses)
        {
            GuessNumber = guessNumber;
            Target = target;
            NumberOfGuesses = numberOfGuesses;
        }

        public int GuessNumber { get; set; }
        public int Target { get; set; }
        public int NumberOfGuesses { get; set; }

        public void UpdateGuess(int newGuessNumber)
        {
            GuessNumber = newGuessNumber;
            NumberOfGuesses += 1;
        }

        public void StartGame(int target)
        {
            GuessNumber = 0;
            Target = target;
            NumberOfGuesses = 0;
        }

        //public bool Equals(Guess actualGuess)
        //{
        //    if(
        //        GuessNumber == actualGuess.GuessNumber
        //        &&
        //        Target == actualGuess.Target
        //        &&
        //        NumberOfGuesses == actualGuess.NumberOfGuesses
        //        &&
        //        MinGuess == actualGuess.MinGuess
        //        &&
        //        MaxGuess == actualGuess.MaxGuess
        //        &&
        //        GetGuesses().SequenceEqual(actualGuess.GetGuesses())
        //        )
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
