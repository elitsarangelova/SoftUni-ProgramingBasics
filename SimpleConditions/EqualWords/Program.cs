using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
          
            if (word1.ToUpper()  == word2.ToUpper() )
            {
                Console.WriteLine("yes" );
                
            }
            else
            {
                Console.WriteLine("no");
            }
           
        }
    }
}
