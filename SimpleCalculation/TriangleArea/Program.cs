using System;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var C = double.Parse(Console.ReadLine());
            var formula = ((C * 1.8) + 32);
            Console.WriteLine(Math.Round(formula, 2));

        }
    }
}