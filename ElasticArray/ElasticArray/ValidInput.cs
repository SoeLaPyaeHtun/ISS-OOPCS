using System;
namespace ElasticArray
{
    public class ValidInput
    {
        public ValidInput()
        {
        }

        public int Valid(string input)
        {
            int validInput = 0;
            try
            {
                validInput = Convert.ToInt32(input);
                if (0 > validInput || validInput > 6)
                {
                    validInput = 0;
                }
            }
            catch
            {
                validInput = 10;
            }
            return validInput;

        }
    }
}
