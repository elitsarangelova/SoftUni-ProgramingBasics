using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryGarfield
{
    class Program
    {
        static void Main(string[] args)
        { 
            decimal sum = decimal.Parse(Console.ReadLine());
            decimal usa = decimal.Parse(Console.ReadLine());
            decimal pizza = decimal.Parse(Console.ReadLine());
            decimal lazania = decimal.Parse(Console.ReadLine());
            decimal sandwiches = decimal.Parse(Console.ReadLine());
            uint p1 = uint.Parse(Console.ReadLine());
            uint l1 = uint.Parse(Console.ReadLine());
            uint s1 = uint.Parse(Console.ReadLine());
            decimal totalsum = pizza / usa * p1 + lazania / usa * l1 + sandwiches / usa * s1;
            decimal final = sum - totalsum;
            decimal final1 = totalsum - sum;
            if (sum>totalsum)
            {
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:F2}.", final);
            }
            else
            {
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:F2}.",Math.Abs(final1));
            }
        }
    }
}
