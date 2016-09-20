using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            bool equals = num1 == num2 && num1==num3 && num2== num3;
            if (equals)
            {
                Console.WriteLine("yes");  
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
