using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuessTheNumber.Classes;
using Xunit;

namespace GuessTheNumberTests
{
    [TestClass]
    public class GuessTests
    {
        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        public void GuessValidatorTestPositive(string inputString, int inputInt)
        {
            var guessValidator = new GuessValidator();

            guessValidator.TryValidate(inputString, out int result);

            Assert.IsTrue(result == inputInt);
        }

        [Theory]
        [InlineData(1)]
        public void GuessEvaluatorTest(int actualTarget)
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