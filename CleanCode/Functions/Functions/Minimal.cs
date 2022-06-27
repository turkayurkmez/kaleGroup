using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class Minimal
    {
        static int getTotal(List<int> numbers)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }
            stopwatch.Stop();
            Console.WriteLine($"foreach: {stopwatch.ElapsedTicks}");
            return total;

        }

        static int getTotalWithLinq(List<int> numbers)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int total = numbers.Sum();
            stopwatch.Stop();
            Console.WriteLine($"Linq Sum: {stopwatch.ElapsedTicks}");
            return total;

        }
    }
}
