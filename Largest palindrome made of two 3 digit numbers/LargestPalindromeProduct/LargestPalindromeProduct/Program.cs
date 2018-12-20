using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalindromeProduct
{
    class Program
    {
        //naći najveći polindrom napravljen od dva 3-znamenkasta broja
        static void Main(string[] args)
        {
            var n = 998001;
            var result = FindPolindrome(n);
           
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int FindPolindrome(int n)
        {
            var polindrome = "";
            for (var i = n-1; i < n; i--)
            {
                var reversedValue = i.ToString().ToCharArray();
                Array.Reverse(reversedValue);
                polindrome = new string(reversedValue);
                if (polindrome.Equals(i.ToString()))
                {
                    var integer = int.Parse(polindrome);
                    for (var j = 100; j <= 999; j++)
                    {                       
                        if (integer % j == 0)
                        {
                            double devide = (double) integer/j;
                            if(devide >= 100 && devide <= 999)
                                return integer;
                        }                                                      
                    }
                }
            }
            return 0;
        }
    }
}
