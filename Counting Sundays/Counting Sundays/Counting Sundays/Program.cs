using System;

namespace Counting_Sundays
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = CountSundays(new DateTime(1901, 1, 1), new DateTime(2000, 12, 31));
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static int CountSundays(DateTime startDate, DateTime endDate)
        {
            var countSundays = 0;
            for (DateTime dt = startDate;dt<endDate;dt = dt.AddDays(1.0))
            {
                if (dt.DayOfWeek == DayOfWeek.Sunday && dt.Day == 1)
                {
                    ++countSundays;
                }
            }
            return countSundays;
        }
    }
}
