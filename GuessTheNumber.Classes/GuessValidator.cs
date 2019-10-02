namespace GuessTheNumber.Classes
{
    public class GuessValidator
    {
        public GuessValidator()
        {
        }

        public bool TryValidate(string input, out int result)
        {
            input = input.Trim();

            result = 0;

            if (double.TryParse(input, out double dblSpeculativeResult))
            {
                if (int.TryParse(dblSpeculativeResult.ToString(), out int intSpeculativeResult))
                {
                    if (intSpeculativeResult >= 1 && intSpeculativeResult <= 1000)
                    {
                        result = intSpeculativeResult;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
