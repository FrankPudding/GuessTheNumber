using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuessTheNumber.Classes;
using Xunit;

namespace GuessTheNumberTests
{
    [TestClass]
    public class GuessTests
    {
        [Theory]
        [InlineData(, )]
        public void StartGameTest(int actualGuessNumber, int actualTarget, int actualNumberOfGuesses, int expectedGuessNumber, int expectedTarget, int expectedNumberOfGuesses)
        {
            actualGuess.StartGame(0);

            Assert.IsTrue(expectedGuess.Equals(actualGuess));
        }

        [TestMethod]
        public void EqualsTrueTest()
        {
            Guess actualGuess = new Guess(1, 2, 3);

            Guess expectedGuess = new Guess(1, 2, 3);
            
            Assert.IsTrue(expectedGuess.Equals(actualGuess));
            
        }

        [TestMethod]
        public void EqualsFalseTest()
        {
            Guess actualGuess = new Guess(0, 2, 3);

            Guess expectedGuess = new Guess(1, 2, 3);
            Assert.IsFalse(expectedGuess.Equals(actualGuess));
        }

        // tests for guessevaluator and guessvalidator

        // make interfaces for writers/readers

        // mocking (interfaces)

        // parameterize

        // resharper/code coverage
    }
}