﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int r = 1; r <= n; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
