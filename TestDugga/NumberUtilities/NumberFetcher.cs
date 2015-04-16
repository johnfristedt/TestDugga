using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberUtilities
{
    public class NumberFetcher
    {
        public static long Fetch(string input)
        {
            long output = -1;
            if (String.IsNullOrEmpty(input.Trim()))
                return output;

            input = input.ToLower();
            char[] acceptedShorthand = { 'k', 'm', 't', 'b' };
            string inputTrimmed = input.Remove(input.Length - 1);

            // Find out if the trimmed input contains any letters
            // Return default output if true
            foreach (var c in inputTrimmed)
                if (char.IsLetter(c))
                    return output;

            // If last input char is a number, return the input number
            if (char.IsNumber(input.Last()))
                return Convert.ToInt64(input);

            // If shorthand is correct, set output to input value or 1 if only shorthand was entered
            if (acceptedShorthand.Contains(input.Last()))
                if (inputTrimmed.Length == 0)
                    output = 1;
                else
                    output = Convert.ToInt64(inputTrimmed);

            // Multiply output by proper factor and return
            switch (input.Last())
            {
                case 'k':
                    return output * 1000;
                case 'm':
                    return output * 1000000;
                case 'b':
                    return output * 1000000000;
                case 't':
                    return output * 1000000000000;
                default:
                    return output;
            }
        }
    }
}
