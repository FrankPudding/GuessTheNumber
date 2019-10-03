using GuessTheNumber.Classes;
using Xunit;

namespace GuessTheNumber.Tests
{
    public class GuessTests
    {
        [Theory]
        [InlineData("1", 1)]
        [InlineData("1.0", 1)]
        [InlineData("2", 2)]
        [InlineData("3", 3)]
        [InlineData("4", 4)]
        [InlineData("5", 5)]
        [InlineData("6", 6)]
        [InlineData("7", 7)]
        [InlineData("8", 8)]
        [InlineData("9", 9)]
        [InlineData("10", 10)]
        public void GuessValidatorTestPositive(string inputString, int inputInt)
        {
            var guessValidator = new GuessValidator();

            guessValidator.TryValidate(inputString, out int result);

            Assert.Equal(inputInt, result);
        }

        [Theory]
        [InlineData("-1")]
        [InlineData("0")]
        [InlineData("1.1")]
        [InlineData("1001")]
        [InlineData("")]
        [InlineData("a")]
        [InlineData("b")]
        public void GuessValidatorTestNegative(string inputString)
        {
            var guessValidator = new GuessValidator();

            Assert.False(guessValidator.TryValidate(inputString, out int result));
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        public void GuessEvaluatorTest(int target)
        {
            var guess = new Guess(target, target, 0);
            var guessEvaluator = new GuessEvaluator();

            Assert.True(guessEvaluator.IsCorrect(guess));
        }

        // tests for guessevaluator and guessvalidator - done

        // make interfaces for writers/readers - done

        // mocking (interfaces)??

        // parameterize - done

        // resharper/code coverage
    }
}