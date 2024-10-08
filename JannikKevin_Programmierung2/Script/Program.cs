using System;
using System.Collections.Generic;

namespace Script
{
    class Einstiegspunkt
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine(Sum(1,10));
            

            

        }

        public static int Sum(int low, int high)
        {
            if (low > high)
            {
                return low;
            }
            return high + Sum(low, high - 1);
        }

        

       
    }
}