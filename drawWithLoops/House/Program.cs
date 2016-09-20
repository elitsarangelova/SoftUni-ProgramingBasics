using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars = 1;
            if (n % 2 == 0)
            {
                stars++;//pechatim 2 zvezdichki
            }
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                int padding = (n - stars) / 2;
                Console.Write(new string('-', padding));
                Console.Write(new string('*', stars));
                Console.WriteLine(new string('-', padding));
                stars = stars + 2; //vseki sledvasht red s 2 zvezdichki poveche
            }
            for (int y = 0; y < n / 2; y++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.WriteLine("|");
            }
        }
    }
}
