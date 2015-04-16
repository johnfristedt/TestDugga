using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberUtilities
{
    public class NumberFetcher
    {
        public static long Fetch(string value)
        {
            long output = -1;
            value = value.ToLower();

            switch (value[value.Length - 1])
            {
                case 'k':
                    return 1000;
                case 'm':
                    return 1000000;
                case 'b':
                    return 1000000000;
                case 't':
                    return 1000000000000;
            }

            return output;
        }
    }
}
