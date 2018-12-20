using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 2;
            var result = Recursive(1, 2, 0,ref sum);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int Recursive(int start, int toSum, int createdNumber,ref int sum)
        {
            createdNumber = start + toSum;
            Console.WriteLine("Created number: " + createdNumber);
            if (createdNumber > 4000000)
                return sum;

            if (createdNumber%2 == 0)
            {
                Console.WriteLine("To sum with to sum {0} + {1}", sum, createdNumber);
                sum += createdNumber;
            }
               
            start = toSum;
            toSum = createdNumber;
            return Recursive(start, toSum, createdNumber,ref sum);

        }
    }
}
