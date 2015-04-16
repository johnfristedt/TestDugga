using NumberUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDugga
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a value: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit") break;

                long value = NumberFetcher.Fetch(input);
                Console.Write(value);
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
