using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10x10stars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new string('a',7));-izpisva 7 puti char a
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(new string('*',10));
            }
        }
    }
}
