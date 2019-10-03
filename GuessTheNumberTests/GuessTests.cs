using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuessTheNumber.Classes;
using Xunit;

namespace GuessTheNumberTests
{
    [TestClass]
    public class GuessTests
    {
        [Theory]
        [InlineData(1)]
        public void StartGameTest(int actualTarget)
        {
            var guess = new Guess(actualTarget, actualTarget, 0);
            var guessEvaluator = new GuessEvaluator();

            guess.StartGame(actualTarget);

            Assert.IsTrue(guessEvaluator.IsCorrect(guess.GuessNumber, guess.Target));
        }

        // tests for guessevaluator and guessvalidator

        // make interfaces for writers/readers - done?

        // mocking (interfaces)??

        // parameterize - done?

        // resharper/code coverage
    }
}