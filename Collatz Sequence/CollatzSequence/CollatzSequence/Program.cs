using System;
using System.Collections.Generic;
using System.Linq;

namespace CollatzSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            const int number = 1000000;

            long sequenceLength = 0;
            long startingNumber = 0;

            for (int i = 2; i <= number; i++)
            {
                int length = 1;
                long sequence = i;
                while (sequence != 1)
                {
                    if ((sequence % 2) == 0)
                    {
                        sequence = sequence / 2;
                    }
                    else
                    {
                        sequence = sequence * 3 + 1;
                    }
                    length++;
                }

                if (length > sequenceLength)
                {
                    sequenceLength = length;
                    startingNumber = i;
                }
            }
            Console.WriteLine(startingNumber);
            Console.ReadLine();
        }
    }
}
