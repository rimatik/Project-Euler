using System;
using System.Collections.Generic;
using System.Numerics;

namespace _1000DigitFibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] arr = new BigInteger[3];
            arr[0] = 1;
            arr[2] = 1;

            BigInteger limit = BigInteger.Pow(10, 999);

            var i = 0;
            var count = 2;

            while (arr[i] < limit)
            {
                i = (i + 1) % 3;
                count++;
                arr[i] = arr[(i + 1) % 3] + arr[(i + 2) % 3];
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
