using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            for (int i = 1; i <= num; i++)
            {
                int n = int.Parse(Console.ReadLine());
                sum = sum + n;
                if (n > max)
                {
                    max = n;
                }
               
            }
            if (max == sum - max)
            {
                Console.WriteLine("Yes Sum = {0}", max);
            }
            else
            {
                int diff = Math.Abs(max - (sum-max));
                Console.WriteLine("No Diff = {0}", diff);
            }
        }
    }
}
