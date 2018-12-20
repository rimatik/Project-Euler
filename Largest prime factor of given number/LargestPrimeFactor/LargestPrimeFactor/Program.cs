using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPrimeFactor
{
    class Program
    {
        //The prime factors of 13195 are 5, 7, 13 and 29.
        //What is the largest prime factor of the number 60 851 475 143 ?
        static void Main(string[] args)
        {

            long n = 600851475143;
            List<long> factors = FindFactors(n);

            foreach (var fact in factors)
            {
                Console.WriteLine(fact);
            }
            Console.ReadKey();
        }

        private static List<long> FindFactors(long num)
        {
            List<long> result = new List<long>();

            while (num % 2 == 0)
            {
                result.Add(2);
                num /= 2;
            }

            long factor = 3;
            while (factor * factor <= num)
            {
                if (num % factor == 0)
                {
                    result.Add(factor);
                    num /= factor;
                }
                else
                {
                    factor += 2;
                }
            }

            if (num > 1) result.Add(num);

            return result;
        }


    }
}
