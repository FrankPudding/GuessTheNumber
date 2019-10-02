using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.Classes
{
    public class GuessEvaluator
    {
        public bool IsCorrect(int guess, int target)
        {
            return guess == target;
        }

        public bool IsTooHigh(int guess, int target)
        {
            return guess > target;
        }

        public bool IsClose(int guess, int target)
        {
            return guess - target < 10 && target - guess < 10;
        }
    }
}
