﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n ; i++)
            {
                Console.Write(new string(' ', n-i));
                Console.Write("*");
                for (int j = 0; j < i-1; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int i =n-1; i > 0; i--)
            {
                Console.Write(new string (' ', n-i));
                Console.Write("*");
                for (int j = 0; j < i - 1; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            
        
         
         
        }
    }
}
