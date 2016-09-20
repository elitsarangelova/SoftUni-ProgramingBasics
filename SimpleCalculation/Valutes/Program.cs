using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valutes
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            string val = Console.ReadLine();
            string output = Console.ReadLine();
            //  double USD = 1.79549
            // double BGN = USD * 1.79549;
            // double USD = BGN / 1.79549;
            // double EUR = BGN / 1.95583;
            //  double GBR = BGN / 2.53405;


            if (val == "BGN" && output == "USD")
            {
                double BGN = sum;
                double USD = sum * 1.79549;
                Console.Write(Math.Round(USD, 2)); Console.WriteLine(" USD");
            }
            else if (val == "BGN" && output == "EUR")
            {
                double BGN = sum;
                double EUR = sum / 1.95583;
                Console.Write(Math.Round(EUR, 2)); Console.WriteLine(" EUR");
            }
            else if (val == "BGN" && output == "GBR")
            {
                double BGN = sum;
                double GBR = sum / 2.53405;
                Console.Write(Math.Round(GBR, 2)); Console.WriteLine(" GBR");
            }
            else if (val == "USD" && output == "BGN")
            {
                double USD = sum;
                double BGN = sum * 1.79549;
                Console.Write(Math.Round(BGN, 2)); Console.WriteLine(" BGN");
            }
            else if (val == "USD" && output == "EUR")
            {
                double USD = sum;
                double EUR = (sum * 1.79549) / 1.95583;
                Console.Write(Math.Round(EUR, 2)); Console.WriteLine(" EUR");
            }
            else if (val == "USD" && output == "GBP")
            {
                double USD = sum;
                double GBP = (sum * 179549) / 2.53405;
                Console.Write(Math.Round(GBP, 2)); Console.WriteLine(" GBP");
            }
            else if (val == "EUR" && output == "BGN")
            {
                double EUR = sum;
                double BGN = sum * 1.95583;
                Console.Write(Math.Round(BGN, 2)); Console.WriteLine(" EUR");
            }
            else if (val == "EUR" && output == "USD")
            {
                double EUR = sum;
                double USD = (sum *1.79549)/ 1.79549;
                Console.Write(Math.Round(USD, 2)); Console.WriteLine(" USD");
            }
            else if (val == "EUR" && output == "GBP")
            {
                double EUR = sum;
                double GBR = (sum * 1.95583) /2.53405 ;
                Console.Write(Math.Round(GBR, 2)); Console.WriteLine(" GBP");
            }
            else if (val == "GBP" && output == "BGN")
            {
                double GBP = sum;
                double BGN = sum * 2.53105;
                Console.Write(Math.Round(BGN, 2)); Console.WriteLine(" BGN");
            }
            else if (val == "GBP" && output == "USD")
            {
                double GBP = sum;
                double USD = (sum * 2.53405) /1.79549 ;
                Console.Write(Math.Round(USD, 2)); Console.WriteLine(" USD");
            }
            else if (val == "GBP" && output == "EUR")
            {
                double GBP = sum;
                double EUR = (sum * 2.53405) / 1.95583;
                Console.Write(Math.Round(EUR, 2)); Console.WriteLine(" EUR");
            }
        }
    }
}
