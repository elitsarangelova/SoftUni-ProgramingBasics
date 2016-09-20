using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double sideOfSquare = double.Parse(Console.ReadLine());
                double areas = sideOfSquare * sideOfSquare;
                areas = Math.Round(areas, 3);
                Console.WriteLine(areas);
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double ab = a * b;
                ab = Math.Round(ab, 3);
                Console.WriteLine(ab);
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * radius * radius;
                area = Math.Round(area, 3);
                Console.WriteLine(area);
            }
            else if(figure=="triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double hside = side * h / 2;
                hside = Math.Round(hside, 3);
                Console.WriteLine(hside);
            }
        }
    }
}
