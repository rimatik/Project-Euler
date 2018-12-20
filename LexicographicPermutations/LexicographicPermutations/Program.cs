using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexicographicPermutations
{
    class Program
    {
        static void Main(String[] args)
        {
            string str = "abcdefghijklm";
            char[] charArry = str.ToCharArray();
            int n;
            int t = 2;
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            int[] f = new int[13];
            for (int i = 0; i < t; i++)
            {
                n = list[i];
                f = getFactoradic(n - 1);
                Console.WriteLine(getPermutation(charArry, f));
            }
            Console.ReadLine();
        }

        // function to get Factoradic representation of a number,n.
        static int[] getFactoradic(int n)
        {
            int[] factoradic = new int[13];
            int i = 1;
            while (n != 0)
            {
                factoradic[13 - i] = n % i;
                n = n / i;
                i++;
            }
            return factoradic;
        }

        // function takes a String,str and Factoradic representation of a number n.
        // returns the nth lexicographic permutaion of character array, str.
        static String getPermutation(char[] str, int[] factoradic)
        {
            Array.Sort(str);
            List<char> res = new List<char>();
            StringBuilder sb = new StringBuilder();
            int pos;
            char c;
            bool[] used = new bool[str.Length]; // by default values are initialised to false.
            for (int i = 0; i < factoradic.Length; i++)
            {
                pos = factoradic[i];
                c = getUnusedCharAtPos(str, pos, used);
                res.Add(c);
            }

            foreach (char some_c in res)
            {
                sb.Append(some_c);
            }
            return (sb.ToString());
        }

        //function to get the yet unused character at a given position in a character array.
        private static char getUnusedCharAtPos(char[] str, int pos, bool[] used)
        {
            int count = -1;
            for (int i = 0; i < str.Length; i++)
            {
                if (!used[i])
                {
                    count++;
                    if (count == pos)
                    {
                        used[i] = true;
                        return str[i];
                    }
                }
            }
            return ' ';
        }

    }
}
