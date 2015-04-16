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
            input = input.ToLower();

            foreach (var c in input.Remove(input.Length - 1))
            {
                if (char.IsLetter(c))
                    return output;
            }

            if (char.IsNumber(input[input.Length - 1]))
                return Convert.ToInt64(input);

            switch (input[input.Length - 1])
            {
                case 'k':
                    return 1000;
                case 'm':
                    return 1000000;
                case 'b':
                    return 1000000000;
                case 't':
                    return 1000000000000;
                default:
                    return output;
            }
        }
    }
}
