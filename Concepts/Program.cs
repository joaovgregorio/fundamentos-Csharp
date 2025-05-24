using System;
using System.Globalization;
using System.Text;

namespace Concepts
{
    internal class Program
    {
        private static void Main()
        {
            Console.Clear();

            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());
        }

        static bool IsWeekend(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }
    }
}