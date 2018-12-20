using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPathSum1
{
    class Program
    {
        public static void Main(String[] args)
        {
            //string str = "Tact Coa";
           
        }

        public static void MathPathSum1()
        {
            var testCases = Console.ReadLine();
            var numOfRows = int.Parse(Console.ReadLine());
            var max = 0;
            var check = -1;
            var sum = 0;
            for (int i = 0; i < numOfRows; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                foreach (var item in tokens)
                {
                    check = int.Parse(item);
                    if (check > max)
                    {
                        max = check;
                    }
                }
                sum += max;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
