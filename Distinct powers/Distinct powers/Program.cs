using System;
using System.Collections.Generic;

namespace Distinct_powers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double>();
            for(int i = 2;i<= 100;i++)
            {
                for (int j = 2; j <= 100; j++)
                {
                    var rez = Math.Pow(i, j);
                    if (!list.Contains(rez))
                        list.Add(rez);
                }
            }
            Console.WriteLine(list.Count);
            Console.ReadLine();
        }
    }
}
