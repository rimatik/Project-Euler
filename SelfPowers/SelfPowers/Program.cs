using System;
using System.Numerics;

namespace SelfPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger sum = 0;
            
            for (int i = 1; i <= 1000; i++)
            {
                sum += BigInteger.Pow(i, i);

            }
            var sumString = sum.ToString();
            var sumSubstring = sumString.Substring(sumString.Length - 10, 10);
            Console.WriteLine(sumSubstring);
            Console.ReadLine();
        }
    }
}
