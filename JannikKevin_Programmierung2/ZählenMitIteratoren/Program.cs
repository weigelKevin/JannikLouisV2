using System;
using System.Collections.Generic;

namespace ZählenMitIteratoren
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int number in CountToTen().Take(700))
            {
                Console.WriteLine(number);
            }
            foreach (int number in CountToTen().Take(700))
            {
                Console.WriteLine(number);
            }
        }

        public static IEnumerable<int> CountToTen()
        {
            for (int i = 1; i <= 10000000000000000; i++)
            {
                yield return i;
            }
        }
    }
}